using System.Runtime.InteropServices.JavaScript;

namespace BlazorBootstrap.Pages;

public partial class Article
{
    protected override async Task OnInitializedAsync()
    {
        await JSHost.ImportAsync("Article", 
            "../Pages/Article.razor.js");

        Init();
    }

    [JSImport("init", "Article")]
    static partial void Init();
}