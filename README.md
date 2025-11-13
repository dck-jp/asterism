# asterism

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![.NET](https://img.shields.io/badge/.NET-10.0-purple.svg)
![Platform](https://img.shields.io/badge/platform-Windows-blue.svg)

**asterism** is a CSV/TSV data visualization tool designed for researchers to quickly visualize 2D numerical data as heatmap images.

## Features

- 📊 **Quick Visualization**: Easily view numerical data arranged in 2D format as heatmap images
- 📁 **Easy File Management**: Browse and open data files through an intuitive file explorer interface
- 📈 **Cross-Section Analysis**: Extract and plot arbitrary rows or columns as line graphs
- 🖼️ **Batch Image Generation**: Generate multiple heatmap images at once
- 🎨 **Flexible Display Options**: Log/Ln scale visualization, customizable color ranges
- 📊 **Supports multiple data formats**: Grid Data and Point Cloud Data (XYZ Format)
- 🚀 **High performance**: Parallel processing + SIMD‑optimized bitmap generation

 
## Supported File Formats

- **File Types**: CSV (comma or space-separated), TSV (tab-separated)
	- **Data Types**: Grid Data (2D matrix), Point Cloud Data (XYZ format)
	- see "Data File Format" section below for details
- **Encodings**: Shift-JIS, EUC, ISO-2022-JP, UTF-7/8/16/32

## System Requirements

- **OS**: Windows 10 or later (64-bit recommended)
- **.NET**: Not required - Runtime is included in the download!

## Installation

### Option 1: Download Pre-built Binary (Recommended)

1. Go to the [Releases](https://github.com/dck-jp/asterism/releases) page
2. Download the latest version ZIP file
   - **asterism-win-x64.zip** for 64-bit Windows (recommended) - ~40MB download, ~120MB extracted
   - **asterism-win-x86.zip** for 32-bit Windows - ~35MB download, ~100MB extracted
3. Extract to any folder
4. Run `asterism.exe`

**No .NET installation required!** - Everything is included in the download.

> **Note**: The download size is larger because it includes the .NET 10 runtime. This ensures the application runs on any Windows 10+ system without additional setup.

### Option 2: Build from Source

```bash
# Clone the repository
git clone https://github.com/dck-jp/asterism.git
cd asterism

# Build the project
dotnet build -c Release

# Run the application
cd bin\Release
asterism.exe
```

## Usage

### Basic Usage

1. Launch `asterism.exe`
2. Open a data file using one of these methods:
   - Drag & drop files onto the window
   - Use the file explorer pane on the left
   - File menu → Open

3. Try the sample files in the `samples` folder to get started

### Batch Image Generation

1. Open the "Image" tab
2. Click "Generate batch images" button
3. All files in the current file list will be converted to images
4. Images are saved in an `img` folder within your selected directory

## Data File Format

### Grid Data (GridCSV / 2D Map Data)

Represents numerical data arranged in a grid—commonly used for surface roughness, X‑ray intensity, and raster data.


Data should be organized as a 2D matrix with numerical values:

```
# Header row (optional)
value1  value2  value3  ...
value4  value5  value6  ...
...
```

- Lines containing non-numeric data are treated as headers
- Delimiters: Tab, comma, space
- Missing values are handled as NaN

### Point Cloud Data (XYZ Format)

Contains X, Y, and Z values (multiple Z columns allowed).

```
X1  Y1  Z1
X2  Y2  Z2
...
```

- Delimiters: Tab, comma, space
- Columns: X, Y, Z (multi‑value supported)
- Conversion: Automatically transformed into grid data

### UseCases

- Surface roughness data (Surface Map / Height Map)
- X‑ray intensity distribution (Intensity Map / Raster Map)
- Visualization of temperature or concentration fields
- 2D projection of point‑cloud data
- Gridding and visualization of scattered data
 -Any other 2D map (Grid / Raster) data



## Dependencies

This project uses the following libraries:

- [CodeD.CSV2Heatmap](https://www.nuget.org/packages/CodeD.CSV2Heatmap/) (1.0.2)
- [DockPanelSuite](https://github.com/dockpanelsuite/dockpanelsuite) (3.1.1)
- [DockPanelSuite.ThemeVS2015](https://github.com/dockpanelsuite/dockpanelsuite) (3.1.1)
- [ZedGraph](https://github.com/ZedGraph/ZedGraph) (5.2.1)

Icons: [Fugue Icons](https://p.yusukekamiyamane.com/) by Yusuke Kamiyamane

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

Copyright (c) 2009-2025 dck-jp

## Contributing

Contributions are welcome! Please feel free to submit issues or pull requests.

## Author

dck-jp

## Changelog

### Version 3.0.0 (2025)
- Upgraded to .NET 10.0
- Modernized codebase

For previous revision history, see [docs/RevisionHistory.txt](docs/RevisionHistory.txt)
