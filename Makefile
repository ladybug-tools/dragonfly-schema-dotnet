.PHONY: sync-google-form

NEW_RELEASE_VERSION ?= 0.0.1
download:
	cd ./.generator/SchemaGenerator && dotnet run --download --updateVersion

sdk:
	cd ./.generator/SchemaGenerator && dotnet run --download --genCsModel --genCsInterface --genTsModel --updateVersion

cs-sdk:
	cd ./.generator/SchemaGenerator && dotnet run --genCsModel --genCsInterface --updateVersion

ts-sdk:
	cd ./.generator/SchemaGenerator && dotnet run --genTsModel --updateVersion

ts-build:
	cd ./src/TypeScriptSDK && npm i
	cd ./src/TypeScriptSDK && npm version $(NEW_RELEASE_VERSION) --allow-same-version && npm run custom-pack
	cp ./src/TypeScriptSDK/*.tgz ./

ts-test:
	cd ./src/TypeScriptSDK.Tests && npm i ./../TypeScriptSDK/dragonfly-schema-$(NEW_RELEASE_VERSION).tgz
	cd ./src/TypeScriptSDK.Tests && npm i honeybee-schema
	cd ./src/TypeScriptSDK.Tests && npm run test
