# Entitas-Standalone

Entitas-Standalone is a pure C# console app using [Entitas](https://github.com/sschmid/Entitas).

There are two project in the solution:

## src/MyProject.csproj
This is a minimal sample project using one generated component.

## jenny/MyProject.Jenny.csproj
Use this project to build the code generator called Jenny.

To start the server please run:

```
dotnet run -c Release --project jenny/MyProject.Jenny.csproj
```

To generate code using the server please run

```
dotnet jenny/bin/Release/net6.0/MyProject.Jenny.dll client gen
```
