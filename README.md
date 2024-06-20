# VirusTotalHelper

## Overview
VirusTotalHelper is a Windows Forms application that allows users to scan files and URLs using the VirusTotal API.

## Features
- Scan files using their hashes and URLs for threats.
- Display scan results.

## Requirements
- Windows 8 or later
- .NET 8.0 or later if using the framework version

## Installation
1. Download the latest release.
2. Extract the downloaded zip file to your desired location.
3. Run the `VirusTotalHelper.exe` file.

## Usage
1. Open the application.
2. Enter your VirusTotal API key when prompted, and restart the application (the restart is required everytime you change the API key).
3. Use the provided options to scan files or URLs (files are scanned using their hashes, not the file itself).

## Notes
This was mostly a test project used to learn Windows Forms, so albeit it works fine, the code itself was frankensteined from another project and could use some work.
I deliberately decided to avoid using any NuGet package like RestSharp that would make this considerabilly better and shorter, since it wasn't my objective.