# ⚡ Odin Tools ⚡

**Odin Tools** is a modern game launcher that provides Bypass and OnlineFix tools for various games across multiple platforms including Ubisoft, EA, Rockstar, Denuvo, and PlayStation.

## Features

| Feature | Description |
|---------|-------------|
| **Bypass Games** | 139+ games with bypass functionality |
| **OnlineFix Games** | 186+ games with online fix support |
| **SteamLess** | Remove Steam DRM from games |
| **Modern UI** | Dark cyan/blue theme with glassmorphism effects |
| **Auto-Updates** | Automatic update checking from GitHub |
| **Multi-Platform** | Support for multiple game platforms |

## Requirements

- Windows 7/8/10/11
- .NET Framework 4.8
- Visual Studio 2022 (for development)

## How It Works

1. **Data Sources:** Game data is loaded from `data.json` and `data-fix.json` hosted on GitHub
2. **Game Downloads:** Fix files are downloaded from the private `OdinTools-GamesFixes` repository
3. **Auto-Update:** The app checks `latest-version.txt` on GitHub for new versions
4. **Local Database:** SQLite stores user progress and library data locally

## For Developers

### Build Instructions

1. Clone this repository:
   ```bash
   git clone https://github.com/oden1999/OdinTools-Source.git
   ```

2. Open `OdinTools.sln` in Visual Studio 2022

3. Restore NuGet packages (includes HandyControl, Newtonsoft.Json, etc.)

4. Build and run

### Project Structure

```
OdinTools/
├── App.xaml / App.xaml.cs       # Application entry point
├── MainWindow.xaml/.cs          # Main window
├── Classes/                     # Helper classes
├── Pages/                       # App pages
├── UserControls/                # Reusable controls
├── Windows/                     # Dialog windows
├── res/                         # Resources (fonts, icons, media)
├── data.json                    # Bypass game data
├── data-fix.json                # OnlineFix game data
└── packages.config              # NuGet packages
```

### Adding New Games

1. Add game entry to `data.json` (Bypass) or `data-fix.json` (OnlineFix)
2. Upload the fix ZIP file to `OdinTools-GamesFixes` repository
3. The app will automatically detect and download the new game

## Data Files

- **data.json** - Contains Bypass game data (downloaded from GitHub)
- **data-fix.json** - Contains OnlineFix game data (downloaded from GitHub)
- **latest-version.txt** - Current version number for auto-update

## License

Original project by LightnigFast. Modified version by Odin Tools Team.

---

> Built with WPF, C#, and love ❤️
