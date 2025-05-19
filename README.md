# MutationTesting

Sample repo for https://www.danmailloux.com/blog/mutation-testing

## Getting Started

### Running Stryker

Note: this project assumes you have up-to-date .NET development tools installed on your machine. If you run into any snags, check out the official [Getting Started](https://stryker-mutator.io/docs/stryker-net/getting-started/) docs from Stryker.

To run Stryker.NET against this repo, run the following commands:

```sh
dotnet restore
```

```sh
dotnet stryker
```

Then open `./StrykerOutput/{now's datetime}/reports/mutation-report.html` in your browser

### Running the Project

There's not much reason to run this project, but if you really want to, here's how:

```sh
dotnet run --project ./MutationTesting.Web/MutationTesting.Web.csproj
```

Then open up <http://localhost:5008/swagger/index.html>

There's not much to do here, but the POST /Message endpoint will log whatever string you send in to console.
