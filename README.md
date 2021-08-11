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

Build and restore the project:

```
dotnet restore
dotnet build --no-restore
```

Tests:

```
dotnet test --no-build --verbosity normal
```