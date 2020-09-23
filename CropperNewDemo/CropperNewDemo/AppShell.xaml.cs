using System;
using System.Collections.Generic;
using CropperNewDemo.ViewModels;
using CropperNewDemo.Views;
using Xamarin.Forms;
using Stormlion.ImageCropper;

namespace CropperNewDemo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
