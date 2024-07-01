using Microsoft.Maui.Controls;
using SaveUp.ViewModels;

namespace SaveUp
{
    public partial class AddProductPage : ContentPage
    {
        public AddProductPage()
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
        }
    }
}
