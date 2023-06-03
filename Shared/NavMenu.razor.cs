using System.Runtime.InteropServices.JavaScript;

namespace BlazorBootstrap.Shared;

public partial class NavMenu
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender) 
        {
            await JSHost.ImportAsync("NavMenu", 
                "../Shared/NavMenu.razor.js");

            Init();
        }
    }

    [JSImport("init", "NavMenu")]
    internal static partial string Init();
}