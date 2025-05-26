set Report_Folder_Name=UnitTestResult
set Report_File_Name=coverage
@REM set MSBuild_Home="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin"
set OpenCover_Path="C:\OpenCover"
set XUnit_Console_Path="C:\Users\OPL\.nuget\packages\xunit.runner.console\2.9.3\"
set Report_Generator_Path="C:\Users\OPL\.nuget\packages\reportgenerator\5.4.5\"

@REM Uncomment the below 2 lines if you also want to build the Unit Test Project before generating the report
echo "Building Unit Test Project"
%MSBuild_Home%\MSBuild.exe UnitTesting.sln /t:"D:\xUnit\TestCalculator"

echo "Creating a report folder if it does not exist..."
IF exist %Report_Folder_Name% (echo %Report_Folder_Name% exists) ELSE (mkdir %Report_Folder_Name% && echo %Report_Folder_Name% created)

echo "Running unit tests and generating XML"
%OpenCover_Path%\OpenCover.Console.exe -register:user -target:%XUnit_Console_Path%\xunit.console.exe -targetargs:".\TestCalculator\bin\Debug\net8.0\TestCalculator.dll -noshadow" -output:".\%Report_Folder_Name%\%Report_File_Name%.xml" -communicationtimeout:120000

echo "Generating Code Coverage Report from XML"
%Report_Generator_Path%\ReportGenerator.exe -reports:".\%Report_Folder_Name%\%Report_File_Name%.xml" -targetdir:.\%Report_Folder_Name% -reporttypes:HTMLInline -sourcedirs:"D:\xUnit\TestCalculator"

echo "Opening results in default browser"
start "" "./%Report_Folder_Name%/index.html"