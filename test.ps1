& .\install-dev-templates.ps1
rm ./TestProject -r -force
dotnet new oneware.extension -o "TestProject" -G "ProtopSolutions"