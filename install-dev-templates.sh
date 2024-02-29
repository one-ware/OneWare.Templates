# Uninstall the OneWare.Templates
dotnet new uninstall OneWare.Templates

# Remove .nupkg files from bin directory and its subdirectories
rm bin/**/*.nupkg

# Pack and capture the output to find the package name
result=$(dotnet pack | grep -oP "Successfully created package '\K(.*)(?=')")

# Install the package
dotnet new install "$result"
