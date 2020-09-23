using System.ComponentModel;
using Xamarin.Forms;
using CropperNewDemo.ViewModels;

namespace CropperNewDemo.Views
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