using Microsoft.Extensions.DependencyInjection;
using OneWare.Essentials.Models;
using OneWare.Essentials.Services;

namespace OneWareExtensionTemplate;

public class OneWareExtensionClassTemplateModule : OneWareModuleBase
{
    public override void RegisterServices(IServiceCollection services)
    {
        // Add your type registrations here
    }

    public override void Initialize(IServiceProvider serviceProvider)
    {
        // Plugin startup code goes here
        
        //This example adds a context menu item for .vhd files
        serviceProvider.Resolve<IProjectExplorerService>().RegisterConstructContextMenu((selected, menuItems) =>
        {
            if (selected is [IProjectFile {Extension: ".vhd"} vhdFile])
            {
                menuItems.Add(new MenuItemModel("Hello World")
                {
                    Header = $"Hello World {vhdFile.Header}"
                });
            }
        });
    }
}