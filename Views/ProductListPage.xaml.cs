using Microsoft.Maui.Controls;
using SaveUp.ViewModels;

namespace SaveUp
{
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
            BindingContext = new ProductListViewModel();
        }
    }
}
