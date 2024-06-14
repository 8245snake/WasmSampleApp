using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace WasmSampleApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            webView.Services = CreateService();
            webView.HostPage = "wwwroot\\index.html";
            webView.RootComponents.Add<Counter>("#app");
        }

        private static ServiceProvider CreateService()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddBlazorWebViewDeveloperTools();


            return services.BuildServiceProvider();
        }
    }
}