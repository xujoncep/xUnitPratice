using System.Diagnostics.CodeAnalysis;

namespace CalculatorApp
{
    public class Greeter
    {
        public string GetGreeting()
        {
            return "Hello, World!";
        }
    }

    public class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            //Step -01: dotnet add package coverlet.collector
            //Step -02: dotnet test --collect:"XPlat Code Coverage"
            //Step -03: dotnet tool install -g dotnet-reportgenerator-globaltool
            //Step -04: reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coveragereport -reporttypes:Html
        }
    }
}
