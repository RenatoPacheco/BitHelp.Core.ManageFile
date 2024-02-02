# BitHelp.Core.ManageFile

[![Licensed under the MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](./LICENSE)
[![Integration Tests](https://github.com/RenatoPacheco/BitHelp.Core.ManageFile/workflows/Integration%20Tests/badge.svg?branch=master)](https://github.com/RenatoPacheco/BitHelp.Core.ManageFile/actions/workflows/integration-tests.yml)
[![NuGet](https://img.shields.io/nuget/v/BitHelp.Core.ManageFile.svg)](https://nuget.org/packages/BitHelp.Core.ManageFile)
[![Nuget](https://img.shields.io/nuget/dt/BitHelp.Core.ManageFile.svg)](https://nuget.org/packages/BitHelp.Core.ManageFile)

This project contains some classes that allow you to manipulate or extract information from files.

# Getting Started

## Software dependencies

[.NET Standard 2.0](https://docs.microsoft.com/pt-br/dotnet/standard/net-standard)

## Installation process

This package is available through Nuget Packages: https://www.nuget.org/packages/BitHelp.Core.ManageFile

**Nuget**
```
Install-Package BitHelp.Core.ManageFile
```

**.NET CLI**
```
dotnet add package BitHelp.Core.ManageFile
```

## Latest releases

#### Release 0.3.0

**Features:**

- Adding svg type

To read about others releases access [RELEASES.md](./RELEASES.md)

# Build and Test

Using Visual Studio Code, you can build and test the project from the terminal.

## Build and restore the project

```
dotnet restore
dotnet build --no-restore
```

## Tests

```
dotnet test --no-build --verbosity normal
```

## Report Generator

[Coverlet] is used as a package in the test project, to generate the test coverage file. But to generate a report, the [Report Generator] must be installed on the computer, in this case in global scope. In this project I am using version 4.8.6.

```	
dotnet tool install --global dotnet-reportgenerator-globaltool --version 4.8.6
```

## Coverage

To generate the test report, run the command below:

```
rm -rf ./coverage ./test/bin ./src/bin ./TestResults
dotnet restore
dotnet build --no-restore
dotnet test --no-build --verbosity=normal --collect:"XPlat Code Coverage" --results-directory ./coverage
reportgenerator "-reports:coverage/**/coverage.cobertura.xml" "-targetdir:coverage/report" -reporttypes:Html
```

Upon execution, the command will generate a test report in the **./coverage/report**.

So I don't have to run each command for each test that wants to generate the report, I created a **./buildReport.sh** to make it easier, so just run the shell script below:

```	
./buildReport.sh
```

[Visual Studio]:<https://visualstudio.microsoft.com/>
[.Net Core 3.1]:<https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-core-3-1>
[.NET 5]:<https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-5>
[Report Generator]:<https://github.com/danielpalme/ReportGenerator>
[Coverlet]:<https://github.com/coverlet-coverage/coverlet>
[shields.io]:<https://shields.io/category/coverage>