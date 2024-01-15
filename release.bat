@echo off
dotnet build src/Limbo.Umbraco.Video --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget