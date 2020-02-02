npx openapi-generator generate -i "https://www.ladybug.tools/dragonfly-schema/model.json"  -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-generator/config.json --type-mappings decimal=double
python .openapi-generator/post_gen_script.py
