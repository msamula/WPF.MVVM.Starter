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

## Quickstart
1. Requirements: .NET 10 SDK and Visual Studio with WPF support.  
2. Install the Template: Open a terminal and run:

         dotnet new install https://github.com/msamula/WPF.MVVM.Starter.git

3. Create your Project: Navigate to your desired project folder and run:

        dotnet new wpfmvvmstarter -n <YOUR_PROJECT_NAME>

4. Open & Run: Open <YOUR_PROJECT_NAME>.sln in Visual Studio and press F5.

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
