# .NET 10 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 10 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10 upgrade.
3. Upgrade src\Asterism\Asterism.csproj to .NET 10
4. If Microsoft.CSharp is not needed after the upgrade, remove it from src\Asterism\Asterism.csproj

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| DockPanelSuite                      | 2.11.0          | 3.1.0       | Recommended for .NET 10                       |
| DockPanelSuite.ThemeVS2015          | 2.11.0          | 3.1.0       | Recommended for .NET 10                       |
| Microsoft.CSharp                    | 4.7.0           | 4.7.0       | Compatible with .NET 10                       |
| SkiaSharp                           | 2.88.8          | 3.0.0       | Recommended for .NET 10                       |
| SkiaSharp.Views.Desktop.Common      | 2.88.8          | 3.0.0       | Recommended for .NET 10                       |
| SkiaSharp.Views.WindowsForms        | 2.88.8          | 3.0.0       | Recommended for .NET 10                       |
| System.Data.DataSetExtensions       | 4.5.0           |             | Remove (part of .NET 10 framework)            |
| ZedGraph                            | 5.1.7           | 5.1.7       | Compatible with .NET 10                       |

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### CodeD.csproj modifications

Project properties changes:
  - Target framework should be changed from `net48` to `net10.0`
  - Remove `app.config` file as it's not needed for .NET 10

NuGet packages changes:
  - SkiaSharp should be updated from `2.88.8` to `3.0.0` (*recommended for .NET 10*)

Other changes:
  - This is a Windows Forms library project that needs to be converted from .NET Framework to .NET 10
  - Update project file to SDK-style format
  - Review and update any Windows-specific code for cross-platform compatibility

#### Asterism.csproj modifications

Project properties changes:
  - Target framework should be changed from `net48` to `net10.0`
  - Remove `app.config` and `packages.config` files as they're not needed for .NET 10

NuGet packages changes:
  - DockPanelSuite should be updated from `2.11.0` to `3.1.0` (*recommended for .NET 10*)
  - DockPanelSuite.ThemeVS2015 should be updated from `2.11.0` to `3.1.0` (*recommended for .NET 10*)
  - Microsoft.CSharp should remain at `4.7.0` (*compatible with .NET 10*)
  - SkiaSharp should be updated from `2.88.8` to `3.0.0` (*recommended for .NET 10*)
  - SkiaSharp.Views.Desktop.Common should be updated from `2.88.8` to `3.0.0` (*recommended for .NET 10*)
  - SkiaSharp.Views.WindowsForms should be updated from `2.88.8` to `3.0.0` (*recommended for .NET 10*)
  - System.Data.DataSetExtensions should be removed (*part of .NET 10 framework*)
  - ZedGraph should remain at `5.1.7` (*compatible with .NET 10*)

Feature upgrades:
  - Convert from .NET Framework Windows Forms to .NET 10 Windows Forms
  - Update application entry point to use top-level statements or new Program.cs structure
  - Replace `ApplicationException` with more specific exception types where appropriate
  - Review System.Drawing usage and consider migration to cross-platform alternatives if needed

Other changes:
  - Remove obsolete .NET Framework-specific configurations
  - Update project references to use SDK-style format
  - Review and test all Windows Forms controls for compatibility with .NET 10
