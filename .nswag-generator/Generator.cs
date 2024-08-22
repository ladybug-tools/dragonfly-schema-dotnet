using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace SchemaGenerator;

public partial class Generator
{
    private static readonly string _generatorFolder = ".nswag-generator";
    public static string sdkName = "DragonflySchema";
    public static string workingDir = Environment.CurrentDirectory;
    public static string rootDir => workingDir.Substring(0, workingDir.IndexOf(_generatorFolder) + _generatorFolder.Length);
    static void Main(string[] args)
    {

        Console.WriteLine($"Current working dir: {workingDir}");
        Console.WriteLine(string.Join(",", args));

        if (!System.IO.Directory.Exists(rootDir))
            throw new ArgumentException($"Invalid {rootDir}");
        Console.WriteLine($"Current root dir: {rootDir}");

        var outputDir = System.IO.Path.Combine(rootDir, "Output");
        System.IO.Directory.CreateDirectory(outputDir);

        //GenTsDTO.Execute();
        GenCsDTO.Execute();

        CleanHoneybeeSchema();

    }

    /// <summary>
    /// Remove files that belongs to Honeybee Schema
    /// </summary>
    static void CleanHoneybeeSchema()
    {
        var docDir = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(rootDir), ".openapi-docs");
        var schemaFile = System.IO.Path.Combine(docDir, "model_mapper.json");
        var json = System.IO.File.ReadAllText(schemaFile, System.Text.Encoding.UTF8);
        Console.WriteLine($"Reading schema from {schemaFile}");
        var jDocObj = JObject.Parse(json);

        var classes = jDocObj["classes"] as JObject;
        var enumns = jDocObj["enums"] as JObject;
        var hbProps = classes.Properties().Where(_ => _.Value.ToString().StartsWith("honeybee_schema.")).Select(_ => _.Name);
        var hbEnums = enumns.Properties().Where(_ => _.Value.ToString().StartsWith("honeybee_schema.")).Select(_ => _.Name);

        var srcDir = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(rootDir), "src", sdkName, "Model");
        var filesTobeRemoved = hbProps.Concat(hbEnums).Select(_ => _.StartsWith("_") ? _.Substring(1) : _).Select(_ => System.IO.Path.Combine(srcDir, _ + ".cs")).ToList();
        foreach (var item in filesTobeRemoved)
        {
            System.IO.File.Delete(item);
        }

        //props == 

    }

}
