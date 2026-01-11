# WPF MVVM Starter

A lightweight, extensible starter template for WPF applications using MVVM, dependency injection and the Microsoft Generic Host.

## About this project
`WPF MVVM Starter` demonstrates a modern structure for `.NET 10` WPF applications. The project uses `Host.CreateDefaultBuilder` for lifecycle management, `Microsoft.Extensions.DependencyInjection` for DI, and `CommunityToolkit.Mvvm` for ViewModel helpers.

## Key features
- Clear separation of concerns: `Views`, `ViewModels`, `Services`, and `Infrastructure`.
- Host-based startup and shutdown logic in `App.xaml.cs`.
- Centralized DI registrations in `Infrastructure/DependencyInjection.cs`.
- Example `INavigationService` / `NavigationService` implementation.
- Easy to extend with additional views, viewmodels and services.

## 🚀 Installation & Usage

Follow these steps to use this project as a template for your own WPF applications.

### 1. Requirements
* [.NET 10 SDK](https://dotnet.microsoft.com/download)
* Visual Studio 2026 (with WPF Workload) or JetBrains Rider

### 2. Install the Template
First, clone this repository and install it into your local `.dotnet` template engine:

```bash
# Clone the repository
git clone https://github.com/msamula/WPF.MVVM.Starter.git

# Install the template
dotnet new install ./WPF.MVVM.Starter
```

Note: After installation, you can safely delete the cloned folder if you wish; the template is stored in your local .NET template cache.

### 3. Create a New Project
Now you can create a new project anywhere on your computer using the template's short name:

```bash
# Create a new project with your own name
dotnet new wpfmvvmstarter -n MyCoolApp
```

### 4. Open & Run

1. Navigate to your new folder: cd MyCoolApp
2. Open MyCoolApp.slnx in Visual Studio.
3. Press F5 to build and run!

## Uninstall

Run: 

```bash
# Uninstall the template
dotnet new uninstall ./WPF.MVVM.Starter
```

If this command does not work, then run the following command to list all installed template packages that can be uninstalled.

```bash
# List all installed template packages that can be uninstalled
dotnet new uninstall
```

## Project layout (excerpt)
- `App.xaml` / `App.xaml.cs` — host integration and application lifecycle  
- `Views/MainWindow.xaml` / `MainWindow.xaml.cs` — startup view  
- `ViewModels/MainWindowViewModel.cs` — example ViewModel  
- `Infrastructure/DependencyInjection.cs` — DI registration  
- `Services/Navigation` — navigation service example

## Tech stack
- .NET 10 (WPF)  
- C# 14  
- Microsoft.Extensions.Hosting  
- Microsoft.Extensions.DependencyInjection  
- Microsoft.Extensions.Configuration.Json
- CommunityToolkit.Mvvm

## License
MIT License

Copyright (c) 2026 MICHAEL SAMULA

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Third-party packages and licenses
This project depends on third-party NuGet packages. Each package is distributed
under its own license; you must verify and comply with those licenses when
distributing or publishing the application.
