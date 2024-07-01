using Microsoft.Maui.Controls;

namespace SaveUp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));
            Routing.RegisterRoute(nameof(ProductListPage), typeof(ProductListPage));
        }
    }
}
