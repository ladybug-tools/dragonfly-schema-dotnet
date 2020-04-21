
# DragonflySchema - the C# library for the Dragonfly Model Schema

This is the documentation for Dragonfly model schema.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.5.11
- SDK version: 1.5.11
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/dragonfly-core](https://github.com/ladybug-tools/dragonfly-core)

## Frameworks supported


- .NET 4.5 or later

## Dependencies


- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
```


## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using DragonflySchema;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out DragonflySchema.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DragonflySchema;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


## Documentation for Models

 - [Model.Adiabatic](docs/Adiabatic.md)
 - [Model.AirBoundaryConstruction](docs/AirBoundaryConstruction.md)
 - [Model.AirBoundaryConstructionAbridged](docs/AirBoundaryConstructionAbridged.md)
 - [Model.AirBoundaryConstructionAbridgedAllOf](docs/AirBoundaryConstructionAbridgedAllOf.md)
 - [Model.AirBoundaryConstructionAllOf](docs/AirBoundaryConstructionAllOf.md)
 - [Model.ApertureConstructionSet](docs/ApertureConstructionSet.md)
 - [Model.ApertureConstructionSetAbridged](docs/ApertureConstructionSetAbridged.md)
 - [Model.Autocalculate](docs/Autocalculate.md)
 - [Model.Autosize](docs/Autosize.md)
 - [Model.Building](docs/Building.md)
 - [Model.BuildingAllOf](docs/BuildingAllOf.md)
 - [Model.BuildingEnergyPropertiesAbridged](docs/BuildingEnergyPropertiesAbridged.md)
 - [Model.BuildingPropertiesAbridged](docs/BuildingPropertiesAbridged.md)
 - [Model.ConstructionSet](docs/ConstructionSet.md)
 - [Model.ConstructionSetAbridged](docs/ConstructionSetAbridged.md)
 - [Model.ConstructionSetAbridgedAllOf](docs/ConstructionSetAbridgedAllOf.md)
 - [Model.ConstructionSetAllOf](docs/ConstructionSetAllOf.md)
 - [Model.ContextShade](docs/ContextShade.md)
 - [Model.ContextShadeAllOf](docs/ContextShadeAllOf.md)
 - [Model.ContextShadeEnergyPropertiesAbridged](docs/ContextShadeEnergyPropertiesAbridged.md)
 - [Model.ContextShadePropertiesAbridged](docs/ContextShadePropertiesAbridged.md)
 - [Model.DatedBaseModel](docs/DatedBaseModel.md)
 - [Model.DetailedWindows](docs/DetailedWindows.md)
 - [Model.DoorConstructionSet](docs/DoorConstructionSet.md)
 - [Model.DoorConstructionSetAbridged](docs/DoorConstructionSetAbridged.md)
 - [Model.ElectricEquipment](docs/ElectricEquipment.md)
 - [Model.ElectricEquipmentAbridged](docs/ElectricEquipmentAbridged.md)
 - [Model.ElectricEquipmentAbridgedAllOf](docs/ElectricEquipmentAbridgedAllOf.md)
 - [Model.ElectricEquipmentAllOf](docs/ElectricEquipmentAllOf.md)
 - [Model.EnergyMaterial](docs/EnergyMaterial.md)
 - [Model.EnergyMaterialAllOf](docs/EnergyMaterialAllOf.md)
 - [Model.EnergyMaterialNoMass](docs/EnergyMaterialNoMass.md)
 - [Model.EnergyMaterialNoMassAllOf](docs/EnergyMaterialNoMassAllOf.md)
 - [Model.EnergyWindowMaterialBlind](docs/EnergyWindowMaterialBlind.md)
 - [Model.EnergyWindowMaterialBlindAllOf](docs/EnergyWindowMaterialBlindAllOf.md)
 - [Model.EnergyWindowMaterialGas](docs/EnergyWindowMaterialGas.md)
 - [Model.EnergyWindowMaterialGasAllOf](docs/EnergyWindowMaterialGasAllOf.md)
 - [Model.EnergyWindowMaterialGasCustom](docs/EnergyWindowMaterialGasCustom.md)
 - [Model.EnergyWindowMaterialGasCustomAllOf](docs/EnergyWindowMaterialGasCustomAllOf.md)
 - [Model.EnergyWindowMaterialGasMixture](docs/EnergyWindowMaterialGasMixture.md)
 - [Model.EnergyWindowMaterialGasMixtureAllOf](docs/EnergyWindowMaterialGasMixtureAllOf.md)
 - [Model.EnergyWindowMaterialGlazing](docs/EnergyWindowMaterialGlazing.md)
 - [Model.EnergyWindowMaterialGlazingAllOf](docs/EnergyWindowMaterialGlazingAllOf.md)
 - [Model.EnergyWindowMaterialShade](docs/EnergyWindowMaterialShade.md)
 - [Model.EnergyWindowMaterialShadeAllOf](docs/EnergyWindowMaterialShadeAllOf.md)
 - [Model.EnergyWindowMaterialSimpleGlazSys](docs/EnergyWindowMaterialSimpleGlazSys.md)
 - [Model.EnergyWindowMaterialSimpleGlazSysAllOf](docs/EnergyWindowMaterialSimpleGlazSysAllOf.md)
 - [Model.EquipmentBase](docs/EquipmentBase.md)
 - [Model.EquipmentBaseAllOf](docs/EquipmentBaseAllOf.md)
 - [Model.ExtrudedBorder](docs/ExtrudedBorder.md)
 - [Model.Face3D](docs/Face3D.md)
 - [Model.FaceSubSet](docs/FaceSubSet.md)
 - [Model.FaceSubSetAbridged](docs/FaceSubSetAbridged.md)
 - [Model.FloorConstructionSet](docs/FloorConstructionSet.md)
 - [Model.FloorConstructionSetAbridged](docs/FloorConstructionSetAbridged.md)
 - [Model.FloorConstructionSetAbridgedAllOf](docs/FloorConstructionSetAbridgedAllOf.md)
 - [Model.GasEquipment](docs/GasEquipment.md)
 - [Model.GasEquipmentAbridged](docs/GasEquipmentAbridged.md)
 - [Model.GasEquipmentAbridgedAllOf](docs/GasEquipmentAbridgedAllOf.md)
 - [Model.GasEquipmentAllOf](docs/GasEquipmentAllOf.md)
 - [Model.Ground](docs/Ground.md)
 - [Model.IDdBaseModel](docs/IDdBaseModel.md)
 - [Model.IDdEnergyBaseModel](docs/IDdEnergyBaseModel.md)
 - [Model.IdealAirSystemAbridged](docs/IdealAirSystemAbridged.md)
 - [Model.IdealAirSystemAbridgedAllOf](docs/IdealAirSystemAbridgedAllOf.md)
 - [Model.Infiltration](docs/Infiltration.md)
 - [Model.InfiltrationAbridged](docs/InfiltrationAbridged.md)
 - [Model.InfiltrationAbridgedAllOf](docs/InfiltrationAbridgedAllOf.md)
 - [Model.InfiltrationAllOf](docs/InfiltrationAllOf.md)
 - [Model.Lighting](docs/Lighting.md)
 - [Model.LightingAbridged](docs/LightingAbridged.md)
 - [Model.LightingAbridgedAllOf](docs/LightingAbridgedAllOf.md)
 - [Model.LightingAllOf](docs/LightingAllOf.md)
 - [Model.LouversBase](docs/LouversBase.md)
 - [Model.LouversByCount](docs/LouversByCount.md)
 - [Model.LouversByCountAllOf](docs/LouversByCountAllOf.md)
 - [Model.LouversByDistance](docs/LouversByDistance.md)
 - [Model.LouversByDistanceAllOf](docs/LouversByDistanceAllOf.md)
 - [Model.Model](docs/Model.md)
 - [Model.ModelAllOf](docs/ModelAllOf.md)
 - [Model.ModelEnergyProperties](docs/ModelEnergyProperties.md)
 - [Model.ModelProperties](docs/ModelProperties.md)
 - [Model.NoLimit](docs/NoLimit.md)
 - [Model.OpaqueConstruction](docs/OpaqueConstruction.md)
 - [Model.OpaqueConstructionAbridged](docs/OpaqueConstructionAbridged.md)
 - [Model.OpaqueConstructionAbridgedAllOf](docs/OpaqueConstructionAbridgedAllOf.md)
 - [Model.OpaqueConstructionAllOf](docs/OpaqueConstructionAllOf.md)
 - [Model.Outdoors](docs/Outdoors.md)
 - [Model.Overhang](docs/Overhang.md)
 - [Model.People](docs/People.md)
 - [Model.PeopleAbridged](docs/PeopleAbridged.md)
 - [Model.PeopleAbridgedAllOf](docs/PeopleAbridgedAllOf.md)
 - [Model.PeopleAllOf](docs/PeopleAllOf.md)
 - [Model.Plane](docs/Plane.md)
 - [Model.ProgramType](docs/ProgramType.md)
 - [Model.ProgramTypeAbridged](docs/ProgramTypeAbridged.md)
 - [Model.ProgramTypeAbridgedAllOf](docs/ProgramTypeAbridgedAllOf.md)
 - [Model.ProgramTypeAllOf](docs/ProgramTypeAllOf.md)
 - [Model.RectangularWindows](docs/RectangularWindows.md)
 - [Model.RepeatingWindowRatio](docs/RepeatingWindowRatio.md)
 - [Model.RoofCeilingConstructionSet](docs/RoofCeilingConstructionSet.md)
 - [Model.RoofCeilingConstructionSetAbridged](docs/RoofCeilingConstructionSetAbridged.md)
 - [Model.RoofCeilingConstructionSetAbridgedAllOf](docs/RoofCeilingConstructionSetAbridgedAllOf.md)
 - [Model.Room2D](docs/Room2D.md)
 - [Model.Room2DAllOf](docs/Room2DAllOf.md)
 - [Model.Room2DEnergyPropertiesAbridged](docs/Room2DEnergyPropertiesAbridged.md)
 - [Model.Room2DPropertiesAbridged](docs/Room2DPropertiesAbridged.md)
 - [Model.ScheduleDay](docs/ScheduleDay.md)
 - [Model.ScheduleDayAllOf](docs/ScheduleDayAllOf.md)
 - [Model.ScheduleFixedInterval](docs/ScheduleFixedInterval.md)
 - [Model.ScheduleFixedIntervalAbridged](docs/ScheduleFixedIntervalAbridged.md)
 - [Model.ScheduleFixedIntervalAbridgedAllOf](docs/ScheduleFixedIntervalAbridgedAllOf.md)
 - [Model.ScheduleFixedIntervalAllOf](docs/ScheduleFixedIntervalAllOf.md)
 - [Model.ScheduleRuleAbridged](docs/ScheduleRuleAbridged.md)
 - [Model.ScheduleRuleAbridgedAllOf](docs/ScheduleRuleAbridgedAllOf.md)
 - [Model.ScheduleRuleset](docs/ScheduleRuleset.md)
 - [Model.ScheduleRulesetAbridged](docs/ScheduleRulesetAbridged.md)
 - [Model.ScheduleRulesetAbridgedAllOf](docs/ScheduleRulesetAbridgedAllOf.md)
 - [Model.ScheduleRulesetAllOf](docs/ScheduleRulesetAllOf.md)
 - [Model.ScheduleTypeLimit](docs/ScheduleTypeLimit.md)
 - [Model.ScheduleTypeLimitAllOf](docs/ScheduleTypeLimitAllOf.md)
 - [Model.Setpoint](docs/Setpoint.md)
 - [Model.SetpointAbridged](docs/SetpointAbridged.md)
 - [Model.SetpointAbridgedAllOf](docs/SetpointAbridgedAllOf.md)
 - [Model.SetpointAllOf](docs/SetpointAllOf.md)
 - [Model.ShadeConstruction](docs/ShadeConstruction.md)
 - [Model.ShadeConstructionAllOf](docs/ShadeConstructionAllOf.md)
 - [Model.SimpleWindowRatio](docs/SimpleWindowRatio.md)
 - [Model.SingleWindow](docs/SingleWindow.md)
 - [Model.Story](docs/Story.md)
 - [Model.StoryAllOf](docs/StoryAllOf.md)
 - [Model.StoryEnergyPropertiesAbridged](docs/StoryEnergyPropertiesAbridged.md)
 - [Model.StoryPropertiesAbridged](docs/StoryPropertiesAbridged.md)
 - [Model.Surface](docs/Surface.md)
 - [Model.Ventilation](docs/Ventilation.md)
 - [Model.VentilationAbridged](docs/VentilationAbridged.md)
 - [Model.VentilationAbridgedAllOf](docs/VentilationAbridgedAllOf.md)
 - [Model.VentilationAllOf](docs/VentilationAllOf.md)
 - [Model.WallConstructionSet](docs/WallConstructionSet.md)
 - [Model.WallConstructionSetAbridged](docs/WallConstructionSetAbridged.md)
 - [Model.WallConstructionSetAbridgedAllOf](docs/WallConstructionSetAbridgedAllOf.md)
 - [Model.WindowConstruction](docs/WindowConstruction.md)
 - [Model.WindowConstructionAbridged](docs/WindowConstructionAbridged.md)
 - [Model.WindowConstructionAbridgedAllOf](docs/WindowConstructionAbridgedAllOf.md)
 - [Model.WindowConstructionAllOf](docs/WindowConstructionAllOf.md)


## Documentation for Authorization

All endpoints do not require authorization.
