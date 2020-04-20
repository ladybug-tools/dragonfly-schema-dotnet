import os
import sys
import json
import urllib.request
import time


time.sleep(3)
root = os.path.dirname(os.path.dirname(__file__))

def remove_honeybeeSchema(source_json):
    interface_dir = os.path.join(root, 'src', 'DragonflySchema', 'Interface')
    model_dir = os.path.join(root, 'src', 'DragonflySchema', 'Model')
    test_dir = os.path.join(root, 'src', 'DragonflySchema.Test', 'Model')

    if source_json.startswith('https:'):
        json_url = urllib.request.urlopen(source_json)
        data = json.loads(json_url.read())
    else:
        with open(source_json, "rb") as jsonFile:
            data = json.load(jsonFile)
    
    for key in data.keys():
        name_space = data[key].title().replace('_', '', 1)
        if name_space.startswith('HoneybeeSchema'):
            # remove the interface:
            layers = name_space.split('.')
            sub_folders = layers[1:-1]
            sub_dir = os.path.join(interface_dir, *sub_folders)
            interface_file = f"{layers[-1]}.cs"
            if layers[-1] == "_Base":
                interface_file = f"{key}.cs"
            interface_tobe_removed = os.path.join(sub_dir, interface_file)
            if os.path.exists(interface_tobe_removed):
                print(f"Removing {interface_tobe_removed}")
                os.remove(interface_tobe_removed)
            
            # remove classes from honeybee schema
            class_tobe_removed = os.path.join(model_dir, f"{key}.cs")
            if os.path.exists(class_tobe_removed):
                print(f"Removing {class_tobe_removed}")
                os.remove(class_tobe_removed)
            
            # remove test classes from honeybee schema
            test_tobe_removed = os.path.join(test_dir, f"{key}Tests.cs")
            if os.path.exists(test_tobe_removed):
                print(f"Removing {test_tobe_removed}")
                os.remove(test_tobe_removed)

args = sys.argv[1:]
if args == []:
    json_file = "https://www.ladybug.tools/dragonfly-schema/model_mapper.json"
else:
    json_file = args[0]

print("Start removing honeybee schema classes")
remove_honeybeeSchema(json_file)
