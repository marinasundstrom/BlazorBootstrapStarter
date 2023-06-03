using System.Runtime.InteropServices.JavaScript;

namespace BlazorBootstrap.Shared;

public partial class LightSwitch
{
    protected override async Task OnInitializedAsync()
    {
            await JSHost.ImportAsync("LightSwitch", 
                "../Shared/LightSwitch.razor.js");

            var mode = GetMode();

            if(mode == "light") darkModeEnabled = false;
            if(mode == "dark") darkModeEnabled = true;
            if(mode == null) darkModeEnabled = null;

            StateHasChanged();

            Init();
    }

    [JSImport("init", "LightSwitch")]
    internal static partial string Init();

    [JSImport("getMode", "LightSwitch")]
    internal static partial string? GetMode();

    [JSImport("setLightMode", "LightSwitch")]
    internal static partial void SetLightMode();

    [JSImport("setDarkMode", "LightSwitch")]
    internal static partial void SetDarkMode();

    [JSImport("setAutoMode", "LightSwitch")]
    internal static partial void SetAutoMode();
}