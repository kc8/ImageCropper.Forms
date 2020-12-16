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

        /// <summary>
        /// If passing in an existing image, this will be populated with its path
        /// If not passing in an existing image, this will contain the original path of the image 
        /// taken with Plugin.Crossmedia implementation
        /// </summary>
        public string OriginalFilePath { get; set; } = null;

        /// <summary>
        /// Removes the original image if you use Take Photo. 
        /// Will not remove the original photo if using Gallery or pass in an image with imageFile
        /// NOT YET IMPLEMENTED 
        /// </summary>
        public bool RemoveOriginal { get; set; } = false;

        public string SelectSourceTitle { get; set; } = "Select source";

        public string TakePhotoTitle { get; set; } = "Take Photo";

        public string PhotoLibraryTitle { get; set; } = "Pick from Photo Library";

        public string CancelButtonTitle { get; set; } = "Cancel";
        
        public PhotoSize ImageSize { get; set; } = PhotoSize.Full;
       
        public int ImageCompressionQuality { get; set; } = 100;

        public Action<string> Success { get; set; }

        public Action Failure { get; set;}

        public async Task Show(Page page, string imageFile = null, bool RemoveOriginal = false)
        {
            MediaFile file = null; 
            OriginalFilePath= imageFile; 
            if (imageFile == null)
            {
                await CrossMedia.Current.Initialize(); 

                string action = await page.DisplayActionSheet(SelectSourceTitle, CancelButtonTitle, null,
                    TakePhotoTitle, PhotoLibraryTitle);
                if (action == TakePhotoTitle)
                {
                    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                    {
                        if (Failure == null) throw new CameraIsNotAvailableException("The Camera is not available or photo functions are not supported"); 
                        Failure?.Invoke();
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
                        if (Failure == null) throw new PhotoPickingIsNotAvailable("Thee photo picker was not available"); 
                        Failure?.Invoke();
                        return;
                    }

                    //If permissions are not setup properly for CrossMedia it can cause crashing
                    file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                    { SaveMetaData = true, CompressionQuality = 100 });
                }
                else
                {
                    Failure?.Invoke();
                    return;
                }

                if (file == null)
                {
                    Failure?.Invoke();
                    return;
                }

                OriginalFilePath = file.Path; 
                imageFile = file.Path;
            }

            // small delay
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            DependencyService.Get<IImageCropperWrapper>().ShowFromFile(this, imageFile); 
        
            // dispose media file
            //file?.Dispose(); 
            this.CleanUp();
        }

        public byte[] GetBytes(string imageFile)
        {
            return DependencyService.Get<IImageCropperWrapper>().GetBytes(imageFile);
        }

        private void CleanUp()
        {
            //TO BE IMPLEMENTED
        }
    }
}
