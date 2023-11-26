using CommunityToolkit.Mvvm.Input;
using OneWare.SDK.Models;
using OneWare.SDK.Services;
using Prism.Ioc;
using Prism.Modularity;

namespace OneWareExtensionTemplate;

public class OneWareExtensionTemplateModule : IModule
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