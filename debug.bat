@echo off
dotnet build src/Limbo.Umbraco.Video --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:\nuget\Umbraco10