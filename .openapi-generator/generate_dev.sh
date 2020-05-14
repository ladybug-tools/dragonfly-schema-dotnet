python .openapi-generator/pre_gen_script.py
npx openapi-generator generate -i "https://www.ladybug.tools/dragonfly-schema/model_inheritance.json"  -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-generator/config.json
python .openapi-generator/post_gen_script.py "https://www.ladybug.tools/dragonfly-schema/model_inheritance.json"

python .openapi-generator/update_assembly_version.py
python .openapi-generator/create_interface.py "https://www.ladybug.tools/dragonfly-schema/model_mapper.json"

python .openapi-generator/remove_honeybee_schema.py "https://www.ladybug.tools/dragonfly-schema/model_mapper.json"
python .openapi-generator/reference_honeybee_schema.py
