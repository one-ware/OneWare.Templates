& .\install-dev-templates.ps1
rm ./TestProject.Test -r -force
dotnet new oneware.extension -o "TestProject.Test" -G "ProtopSolutions"