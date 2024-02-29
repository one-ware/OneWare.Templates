# Dotnet Templates for OneWare

[![Publish Nuget Packages](https://github.com/ProtopSolutions/OneWare.Templates/actions/workflows/publish-nuget.yml/badge.svg)](https://github.com/ProtopSolutions/OneWare.Templates/actions/workflows/publish-nuget.yml)

For more information about `dotnet new` templates see [here](https://blogs.msdn.microsoft.com/dotnet/2017/04/02/how-to-create-your-own-templates-for-dotnet-new/).

## Installing the templates

Run from a command line (`.NET 8`):

```powershell
dotnet new install OneWare.Templates
```

The templates should now be available in `dotnet new list`:

```
Template Name                        Short Name                 Language  Tags
-----------------------------------  -------------------------  --------  -----------------------------------------
OneWare Extension                    oneware.extension          [C#]      OneWare/FPGA/Extension
```

# Creating a new Application

To create an OneWare Extension Project called `OneWare.MyExtension` in its own subdirectory, run:

```
dotnet new oneware.extension -o OneWare.MyExtension
```

Available parameters:

``-F, --Framework``

*Description*: The target framework for the project.

*Options*: **net8.0**

*By default*: net8.0


``-G, --GithubUser``

*Description*: The Github Account/Organization Name for this repo. This will simplify generating the
                                 README file and oneware-extension.json

*By default*: GithubUser
