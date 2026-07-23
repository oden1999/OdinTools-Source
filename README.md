# Odin Tools

**Odin Tools** is a modern game launcher that provides access to hundreds of PC games with Bypass and OnlineFix support.

## Features

- 139+ Bypass games
- 186+ OnlineFix games  
- Modern neon UI with cyan theme (#00D4FF)
- Automatic updates from GitHub repository
- No store/shop section

## Setup Instructions

### 1. Requirements
- Visual Studio 2022
- .NET Framework 4.8 Developer Pack
- NuGet package manager (included in VS)

### 2. Clone and Build
```bash
git clone https://github.com/oden1999/OdinTools-Source.git
cd OdinTools-Source
```
Open `OdinTools.sln` in Visual Studio and build (Ctrl+Shift+B).

### 3. Configure GitHub Token
Create a file named `odin_token.txt` in the application output folder (bin/Debug or bin/Release) and paste your GitHub Personal Access Token.

To get a token:
1. Go to https://github.com/settings/tokens
2. Create a new token with `repo` scope
3. Copy and paste it into `odin_token.txt`

### 4. Run
Press F5 in Visual Studio to run, or execute the built EXE from bin/Release.

## Data Sources

All game data is fetched from this repository:
- `data.json` - Bypass games catalog
- `data-fix.json` - OnlineFix games catalog
- `latest-version.txt` - Version check for auto-updates

## License

MIT License - see LICENSE file for details.
