@echo off
REM Check if git is installed
git --version >nul 2>&1
IF ERRORLEVEL 1 (
    echo Git is not installed. Please install Git to use this script.
    exit /b
)

REM Clone the repository
git clone https://github.com/CursedPrograms/gltf-Exporter.git

echo Download complete.
pause
