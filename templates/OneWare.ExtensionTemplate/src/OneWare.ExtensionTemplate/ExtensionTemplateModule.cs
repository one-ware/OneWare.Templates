using CommunityToolkit.Mvvm.Input;
using OneWare.SDK.Models;
using OneWare.SDK.Services;
using Prism.Ioc;
using Prism.Modularity;

namespace OneWare.ExtensionTemplate;

public class ExtensionTemplateModule : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        containerProvider.Resolve<IProjectExplorerService>().RegisterConstructContextMenu(x =>
        {
            if (x is [IProjectFile {Extension: ".vhd"} json])
            {
                return new[]
                {
                    new MenuItemModel("Hello World")
                    {
                        Header = "Hello World"
                    }
                };
            }
            return null;
        });
    }
}