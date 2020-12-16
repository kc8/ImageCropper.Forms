using Plugin.Media;
using Plugin.Media.Abstractions;
using Stormlion.ImageCropper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace CropperDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CrossMedia.Current.Initialize();
        }

        protected async void OnClickedRectangle(object sender, EventArgs e)
        {
            await new ImageCropper()
            {
                //                PageTitle = "Test Title",
                //                AspectRatioX = 1,
                //                AspectRatioY = 1,
                Success = (imageFile) =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        imageView.Source = ImageSource.FromFile(imageFile);
                    });
                }
            }.Show(this);
        }

        private async void OnClickedCircle(object sender, EventArgs e)
        {
            await new ImageCropper()
            {
                CropShape = ImageCropper.CropShapeType.Oval,
                Success = (imageFile) =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        imageView.Source = ImageSource.FromFile(imageFile);
                    });
                }
            }.Show(this);
        }
    }
}

