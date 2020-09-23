using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stormlion.ImageCropper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CropperNewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cropper : ContentPage
    {
        public Cropper()
        {
            InitializeComponent();
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
                        imageView.Source =  ImageSource.FromFile(imageFile);
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