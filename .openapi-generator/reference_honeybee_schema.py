import os
import json
import urllib.request
import re

root = os.path.dirname(os.path.dirname(__file__))


def get_honeybee_schema_version(url):
    json_url = urllib.request.urlopen(url)
    data = json.loads(json_url.read())
    version = data['versions'][-1]
    print(f"Honeybee Schema: {version}")
    return version


def add_reference_honeybeeSchema(new_version):
    config = os.path.join(root, 'src', 'DragonflySchema', 'packages.config')
    nuspec = os.path.join(root, 'src', 'DragonflySchema', 'DragonflySchema.nuspec')
    csproj = os.path.join(root, 'src', 'DragonflySchema', 'DragonflySchema.csproj')
    
    rex = r"(?<=HoneybeeSchema\"\sversion=\")\S+(?=\")"
    update_version(config, rex, new_version)
    update_version(nuspec, rex, new_version)
    
    rex = r"(?<=HoneybeeSchema.)\S+(?=\\lib)"
    update_version(csproj, rex, new_version)

    # update DragonflySchema.Test
    config_test = os.path.join(root, 'src', 'DragonflySchema.Test', 'packages.config')
    csproj_test = os.path.join(root, 'src', 'DragonflySchema.Test', 'DragonflySchema.Test.csproj')
    update_version(config_test, rex, new_version)
    update_version(csproj_test, rex, new_version)


def update_version(file, rex_match, new_version):
    f = open(file, "rt", encoding='utf-8')
    data = f.read()
    data = re.sub(rex_match, new_version, data)
    f.close()
    print(f"Update {file} honeybeeSchema reference to: {new_version}")
    # save data
    f = open(file, "wt", encoding='utf-8')
    f.write(data)
    f.close()


json_file = "https://api.nuget.org/v3-flatcontainer/HoneybeeSchema/index.json"

print("Start processing reference honeybee schema")
honeybeeSchema_version = get_honeybee_schema_version(json_file)
add_reference_honeybeeSchema(honeybeeSchema_version)
