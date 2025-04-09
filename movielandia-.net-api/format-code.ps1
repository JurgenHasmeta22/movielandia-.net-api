Write-Host "Starting code formatting with CSharpier..." -ForegroundColor Cyan

# Get the directory of the script
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

# Format all C# files in the project directory
dotnet csharpier "$scriptDir"

Write-Host "Code formatting completed!" -ForegroundColor Green
Write-Host "Files formatted using CSharpier version:" -NoNewline
dotnet tool list --global | Where-Object { $_ -match "csharpier" }