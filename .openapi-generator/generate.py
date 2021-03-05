import subprocess
import os
import time


root = os.getcwd()
doc_folder = os.path.join(root, '.openapi-docs')
generator_folder = os.path.join(root, '.openapi-generator')

# '.openapi-docs/model_inheritance.json'
json1 = os.path.join(doc_folder, 'model_inheritance.json')

# update version
# python3 .openapi-generator/pre_gen_script.py ".openapi-docs/model_inheritance.json"
subprocess.call(f"python3 {generator_folder}/pre_gen_script.py {json1}", shell=True)


# run openapi tool to generate schema
template = f"{generator_folder}/templates/csharp"
config = f"{generator_folder}/.openapi-config.json"

# npx @openapitools/openapi-generator-cli generate -i ".openapi-docs/model_inheritance.json"  -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-config.json 
subprocess.call(f"npx @openapitools/openapi-generator-cli generate -i {json1} -t {template} -g csharp -o . --skip-validate-spec -c {config}", shell=True)


# post process files
# python3 .openapi-generator/post_gen_script.py ".openapi-docs/model_inheritance.json"
time.sleep(1)
subprocess.call(f"python3 {generator_folder}/post_gen_script.py {json1}", shell=True)


# update assembly version
time.sleep(1)
subprocess.call(f"python3 {generator_folder}/update_assembly_version.py", shell=True)


mapper = os.path.join(doc_folder, 'model_mapper.json')

# python3 .openapi-generator/create_interface.py ".openapi-docs/model_mapper.json"
time.sleep(1)
subprocess.call(f"python3 {generator_folder}/create_interface.py {mapper}", shell=True)


# remove honeybee files
time.sleep(1)
subprocess.call(f"python3 {generator_folder}/remove_honeybee_schema.py {mapper}", shell=True)


# remove src/DragonflySchema/Model/OpenAPIGenBaseModel.cs
time.sleep(1)
tobe_removed = os.path.join(root, 'src/DragonflySchema/Model/OpenAPIGenBaseModel.cs')
os.remove(tobe_removed)


# test to build the project
time.sleep(1)
subprocess.call("dotnet build -c Release /nowarn:CS0472,CS0108,CS0114", shell=True)
