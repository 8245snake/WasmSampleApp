using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using WasmSampleApp.Shared;


namespace WasmSampleApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            webView.Services = CreateService();
            webView.HostPage = "wwwroot\\index.html";
            webView.RootComponents.Add<App>("#app");
            webView.RootComponents.Add<HeadOutlet>("head::after");
            
        }

        private ServiceProvider CreateService()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddBlazorWebViewDeveloperTools();
            services.AddMudServices();


            return services.BuildServiceProvider();
        }
    }
}