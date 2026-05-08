# Blazor Electron App

A demonstration of integrating [Syncfusion<sup style="font-size:70%">&reg;</sup> Blazor components](https://www.syncfusion.com/blazor-components) with the **Electron** framework to build modern desktop applications.

## Overview

This project showcases how to build robust desktop applications by combining:

- **Blazor Server** - For building interactive web-based UIs using C# and Razor components
- **Electron** - For packaging and deploying as native desktop applications
- **Syncfusion Blazor Components** - For rich, enterprise-grade UI controls including grids, charts, and more

## Features

- **Desktop-ready** - Seamless Electron integration for native app experience
- **Syncfusion UI components** - Pre-configured with Syncfusion Blazor Grid and Themes
- **Cross-platform** - Build for Windows, macOS, and Linux (x64, ARM64)
- **Modern Blazor** - Interactive server rendering and real-time component updates

## Prerequisites

Before you get started, ensure you have the following installed:

- [.NET SDK 10.0](https://dotnet.microsoft.com/download/dotnet)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)
- [Node.js](https://nodejs.org) (v14 or later) - Required by ElectronNET

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/blazor-electron-app
cd blazor-electron-app
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

- [ElectronNET Guide](https://github.com/ElectronNET/Electron.NET)
- [Electron framework documentation](https://www.electronjs.org/docs)
