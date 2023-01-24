using MapsTeste3._0.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MapsTeste3._0.Views
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