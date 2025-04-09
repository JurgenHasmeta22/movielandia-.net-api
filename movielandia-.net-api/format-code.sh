#!/bin/bash

echo "Starting code formatting with CSharpier..."

# Get the directory of the script
SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"

# Format all C# files in the project directory
dotnet csharpier "$SCRIPT_DIR"

echo "Code formatting completed!"
echo -n "Files formatted using CSharpier version: "
dotnet tool list --global | grep csharpier