using LoginSystem.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginSystem.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}