# fAInances

fAInances is a simple personal finance tracker that helps you understand, control, and optimize your spending by easily tracking income, expenses, and monthly budgets.

## Tech stack

- ASP.NET Core 10 + Blazor (Interactive Server)
- MongoDB 7.0 (via the official `MongoDB.Driver`)

## Running locally

Prerequisites: .NET 10 SDK and Docker.

1. Run the app:

    ```bash
    dotnet run --project src/fAInances.Web
    ```

2. Open http://localhost:5227.

On first start the app creates its indexes and seeds a few default categories.

## Running tests

```bash
dotnet test
```

The service tests run against a throwaway MongoDB server started by [EphemeralMongo](https://github.com/asimmon/ephemeral-mongo), so Docker is not needed for them. The `mongod` binaries are downloaded from downloads.mongodb.org on the first run and cached locally.
