@echo off
set Report_Folder_Name=UnitTestResult
set Report_File_Name=coverage
set DotNet_Path= "D:\xUnit\UnitTesting\bin\Debug\net8.0"

echo "Building the solution..."
%DotNet_Path% build UnitTesting.sln

echo "Creating a report folder if it does not exist..."
IF exist %Report_Folder_Name% (echo %Report_Folder_Name% exists) ELSE (mkdir %Report_Folder_Name% && echo %Report_Folder_Name% created)

echo "Running unit tests with coverage..."
%DotNet_Path% TestCalculator --no-build --collect:"XPlat Code Coverage" --results-directory:.\%Report_Folder_Name% TestCalculator

echo "Installing ReportGenerator if not already installed..."
%DotNet_Path% tool install -g dotnet-reportgenerator-globaltool 2>nul || echo "ReportGenerator already installed"

echo "Generating Code Coverage Report from XML"
%DotNet_Path% reportgenerator -reports:".\%Report_Folder_Name%\**\coverage.cobertura.xml" -targetdir:.\%Report_Folder_Name% -reporttypes:HTML;HTMLSummary

echo "Opening results in default browser"
start "" "./%Report_Folder_Name%/index.html"