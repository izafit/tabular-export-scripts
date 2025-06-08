# tabular-export-scripts

**🇵🇱 Opis**  
Zbiór skryptów C# (.csx) do Tabular Editor 2, które pozwalają:  
1. Eksportować struktury modelu (tabele, kolumny, miary, relacje) do czytelnego JSON-a.  
2. Ułatwić automatyczną dokumentację i dalsze przetwarzanie (np. generowanie opisów przez AI).  
3. Integrację z CI/CD (uruchamianie skryptów z linii komend).

**🇬🇧 Description**  
A collection of C# scripts (.csx) for Tabular Editor 2 that let you:  
1. Export model structures (tables, columns, measures, relationships) into a human-friendly JSON.  
2. Facilitate automated documentation and further processing (e.g. AI-driven description generation).  
3. Integrate easily in CI/CD workflows (CLI scripting support).

---

## 📁 Zawartość

- `ExportFullModel.csx` – pełny eksport tabel, miar i relacji do `FullModelDocumentation.json`.  
- `ExportMeasuresOnly.csx` – szybki eksport samych miar do `MeasuresDocumentation.json`.  
- `ImportDescriptions.csx` – import wygenerowanych przez AI opisów z JSON z powrotem do modelu.
