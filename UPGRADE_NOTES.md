# CaliburnTreeView - Caliburn.Micro 5.0 Beta Upgrade

## Changes Made

### 1. Project Upgrade
- **Target Framework**: Updated from `netcoreapp3.1` to `net8.0-windows`
- **SDK**: Changed from `Microsoft.NET.Sdk.WindowsDesktop` to `Microsoft.NET.Sdk` with `UseWPF=true`
- **Caliburn.Micro**: Upgraded from `4.0.136-rc` to `5.0.138-beta`

### 2. New Window Functionality

#### Added Files:
- `ViewModels/NewWindowViewModel.cs` - ViewModel for the new window
- `Views/NewWindowView.xaml` - XAML view for the new window
- `Views/NewWindowView.xaml.cs` - Code-behind for the new window

#### Modified Files:
- `ViewModels/ShellViewModel.cs` - Added IWindowManager injection and OpenNewWindow method
- `Views/ShellView.xaml` - Added toolbar with navigation buttons and "Open New Window" button

### 3. Key Features Added

#### New Window Functionality
The application now includes the ability to open a new window from the main shell:

1. **OpenNewWindow Method**: Added in `ShellViewModel` that uses `IWindowManager.ShowWindowAsync()` to open the new window
2. **NewWindowViewModel**: A simple screen that displays information about when it was opened
3. **UI Integration**: Added a prominent "Open New Window" button in the main shell toolbar

#### Async/Await Patterns
Updated all navigation methods in `ShellViewModel` to properly use async/await patterns:
- `ShowFamilyTree()` -> `async void ShowFamilyTree()`
- `ShowDashboard()` -> `async void ShowDashboard()`
- `ShowMenuTreeViewModel()` -> `async void ShowMenuTreeViewModel()`
- `ShowEmployeeTreeViewModel()` -> `async void ShowEmployeeTreeViewModel()`

### 4. UI Improvements

#### Main Shell Window
- Updated window title to "CaliburnTreeView - Caliburn.Micro 5.0 Beta Demo"
- Replaced commented-out menu with a functional toolbar
- Added clear navigation buttons for all existing views
- Added highlighted "Open New Window" button

#### New Window
- Displays current timestamp when opened
- Shows demonstration message about Caliburn.Micro 5.0 Beta
- Includes close button functionality
- Window opens centered relative to parent

### 5. Dependency Injection

The `ShellViewModel` now properly receives `IWindowManager` through constructor injection, which is registered in the `Bootstrapper.cs` as a singleton.

## How to Use

1. Build and run the application
2. Use the toolbar buttons to navigate between different views:
   - Dashboard
   - Family Tree
   - Menu Tree
   - Employee Tree
3. Click "Open New Window" to demonstrate the new window functionality
4. The new window will open with current timestamp and can be closed independently

## Compatibility Notes

- The project now targets .NET 8.0-windows for modern framework support
- Caliburn.Micro 5.0 Beta provides improved async support and performance
- All existing functionality is preserved while adding new window capabilities
- The application maintains the same TreeView demonstrations as before

## Building the Application

To build this application, you'll need:
- .NET 8.0 SDK
- Windows Desktop development workload (for WPF support)
- Visual Studio 2022 or compatible IDE

```bash
dotnet restore
dotnet build
dotnet run
```