using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using MudBlazor_Shared;

namespace MudBlazor_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddBlazorWebViewDeveloperTools();
            services.AddMudServices();

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Routes>("#app");
        }
    }
}
