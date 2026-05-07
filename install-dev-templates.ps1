dotnet new uninstall OneWare.Templates
Remove-Item bin/**/*.nupkg
$null = dotnet pack
$package = Get-ChildItem .\bin -Filter 'OneWare.Templates*.nupkg' -Recurse |
	Sort-Object LastWriteTime -Descending |
	Select-Object -First 1 -ExpandProperty FullName
dotnet new install $package