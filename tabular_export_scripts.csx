using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// Zbierz wszystkie dane do prostego obiektu
var doc = new {
    Tables = Model.Tables.Select(t => new {
        Name        = t.Name,
        Description = t.Description ?? "",
        Columns     = t.Columns.Select(c => new {
            Name        = c.Name,
            DataType    = c.DataType.ToString(),
            IsHidden    = c.IsHidden,
            Description = c.Description ?? ""
        }).ToList()
    }).ToList(),

    Measures = Model.AllMeasures.Select(m => new {
        Table      = m.Table.Name,
        Name       = m.Name,
        Expression = m.Expression,
        Description= m.Description ?? ""
    }).ToList(),

    Relationships = Model.Relationships.Select(r => new {
        FromTable  = r.FromTable.Name,
        FromColumn = r.FromColumn.Name,
        ToTable    = r.ToTable.Name,
        ToColumn   = r.ToColumn.Name,
        IsActive   = r.IsActive
    }).ToList()
};

// Serializacja do czytelnego JSON-a
var settings = new JsonSerializerSettings {
    ContractResolver = new CamelCasePropertyNamesContractResolver(),
    Formatting       = Formatting.Indented
};
string json = JsonConvert.SerializeObject(doc, settings);

// Zapisz plik – tutaj podaj własną ścieżkę
var outputPath = @"C:sciezka\.json";  
File.WriteAllText(outputPath, json);
