using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stormlion.ImageCropper
{
    public class ImageCropper
    {
        public static ImageCropper Current { get; set; }

        public ImageCropper()
        {
            Current = this;
        }

        public enum CropShapeType
        {
            Rectangle,
            Oval
        };


        public CropShapeType CropShape { get; set; } = CropShapeType.Rectangle;

        public int AspectRatioX { get; set; } = 0;

        public int AspectRatioY { get; set; } = 0;

        public string PageTitle { get; set; } = null;

        public string SelectSourceTitle { get; set; } = "Select source";

        public string TakePhotoTitle { get; set; } = "Take Photo";

        public string PhotoLibraryTitle { get; set; } = "Pick from Photo Library";

        public string CancelButtonTitle { get; set; } = "Cancel";
        public PhotoSize ImageSize { get; set; } = PhotoSize.Full;
        public int ImageCompressionQuality { get; set; } = 100;

        public Action<string> Success { get; set; }

        public Action Faiure { get; set; }

        public async Task Show(Page page, string imageFile = null)
        {
            MediaFile file = null; //not doing this
            if (imageFile == null)
            {
                await CrossMedia.Current.Initialize(); 

                string action = await page.DisplayActionSheet(SelectSourceTitle, CancelButtonTitle, null,
                    TakePhotoTitle, PhotoLibraryTitle);
                if (action == TakePhotoTitle)
                {
                    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                    {
                        await page.DisplayAlert("No Camera", "No camera available.", "OK");
                        Faiure?.Invoke();
                        return;
                    }

                    file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        PhotoSize = ImageSize,
                        CompressionQuality = ImageCompressionQuality,
                    });
                }
                else if (action == PhotoLibraryTitle)
                {
                    if (!CrossMedia.Current.IsPickPhotoSupported)
                    {
                        await page.DisplayAlert("Error", "This device is not supported to pick photo.", "OK");
                        Faiure?.Invoke();
                        return;
                    }

                    file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                        {SaveMetaData = true, CompressionQuality = 100});
                }
                else
                {
                    Faiure?.Invoke();
                    return;
                }

                if (file == null)
                {
                    Faiure?.Invoke();
                    return;
                }

                imageFile = file.Path;
            }

            // small delay
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            DependencyService.Get<IImageCropperWrapper>().ShowFromFile(this, imageFile); 

            // dispose media file
          //  if (file != null) file?.Dispose(); 
            //file?.Dispose(); //Object Reference not set to an instance of an object 
        }

        public byte[] GetBytes(string imageFile)
        {
            return DependencyService.Get<IImageCropperWrapper>().GetBytes(imageFile);
        }
    }
}
