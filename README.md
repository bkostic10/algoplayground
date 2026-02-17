# AlgoPlayground (.NET)

Single-project setup for source and tests:

- `src/AlgoPlayground.csproj`
- `tests/AlgoPlayground.Tests.csproj`

Current starter scenario:

- `src/_Init/Program.cs`
- `src/_Init/SumCalculator.cs`
- `tests/_Init/UnitTest1.cs`

## Commands

```bash
dotnet restore AlgoPlayground.sln
dotnet build AlgoPlayground.sln
dotnet test AlgoPlayground.sln
```

Run `_Init` explicitly:

```bash
dotnet run --project src/AlgoPlayground.csproj -p:StartupObject=AlgoPlayground._Init.Program -- 3 4 5
```

## Add new scenario

1. Create `src/<Scenario>/Program.cs` with namespace `AlgoPlayground.<Scenario>` and class `Program`.
2. Add tests under `tests/<Scenario>/`.
3. Run that scenario explicitly:

```bash
dotnet run --project src/AlgoPlayground.csproj -p:StartupObject=AlgoPlayground.<Scenario>.Program
```
