using Microsoft.Maui.Controls;
using SaveUp.ViewModels;

namespace SaveUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
