# Uninstall the OneWare.Templates
dotnet new uninstall OneWare.Templates

# Remove .nupkg files from bin directory and its subdirectories
rm bin/**/*.nupkg

# Pack and pick the template package from the output directory
dotnet pack > /dev/null
result=$(find bin -name 'OneWare.Templates*.nupkg' -print | sort | tail -n 1)

# Install the package
dotnet new install "$result"
