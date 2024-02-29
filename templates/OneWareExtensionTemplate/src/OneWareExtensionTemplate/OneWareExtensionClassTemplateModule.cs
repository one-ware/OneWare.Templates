using OneWare.Essentials.Models;
using OneWare.Essentials.Services;
using OneWare.Essentials.ViewModels;
using Prism.Ioc;
using Prism.Modularity;

namespace OneWareExtensionTemplate;

public class OneWareExtensionClassTemplateModule : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        //This example adds a context menu for .vhd files
        containerProvider.Resolve<IProjectExplorerService>().RegisterConstructContextMenu(x =>
        {
            if (x is [IProjectFile {Extension: ".vhd"} json])
            {
                return new[]
                {
                    new MenuItemViewModel("Hello World")
                    {
                        Header = "Hello World"
                    }
                };
            }
            return null;
        });
    }
}