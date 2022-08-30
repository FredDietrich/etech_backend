- Para criar uma migration:
```bash
dotnet ef migrations add nomeDaMigration 
```

- Para rodar uma migration:
```bash
dotnet ef database update
```

- Para criar um controller:
```bash
dotnet-aspnet-codegenerator controller -name nomeController -async -api -m nomeDoModel -dc nomeDoContext -outDir pastaDeSaida
```
