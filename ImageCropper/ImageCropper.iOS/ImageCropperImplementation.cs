﻿using CoreGraphics;
using Foundation;
using System;
using System.Diagnostics;
using UIKit;
using Xamarin.TOCropView;

namespace Stormlion.ImageCropper.iOS
{
    public class ImageCropperImplementation : IImageCropperWrapper 
    {
        public void ShowFromFile(ImageCropper imageCropper, string imageFile)
        {
            UIImage image = UIImage.FromFile(imageFile);

            TOCropViewController cropViewController;

            if(imageCropper.CropShape == ImageCropper.CropShapeType.Oval)
            {
                cropViewController = new TOCropViewController(TOCropViewCroppingStyle.Circular, image);
            }
            else
            {
                cropViewController = new TOCropViewController(image);
            }

            if(imageCropper.AspectRatioX > 0 && imageCropper.AspectRatioY > 0)
            {
                cropViewController.AspectRatioPreset = TOCropViewControllerAspectRatioPreset.Custom;
                cropViewController.ResetAspectRatioEnabled = false;
                cropViewController.AspectRatioLockEnabled = true;
                cropViewController.CustomAspectRatio = new CGSize(imageCropper.AspectRatioX, imageCropper.AspectRatioY);
            }

            cropViewController.OnDidCropToRect = (outImage, cropRect, angle) =>
            {
                Finalize(imageCropper, outImage);
            };

            cropViewController.OnDidCropToCircleImage = (outImage, cropRect, angle) =>
            {
                Finalize(imageCropper, outImage);
            };

            cropViewController.OnDidFinishCancelled = (cancelled) =>
            {
                imageCropper.Failure?.Invoke();
                UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
            };

            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(cropViewController, true, null);

            if (!string.IsNullOrWhiteSpace(imageCropper.PageTitle) && cropViewController.TitleLabel != null)
            {
                UILabel titleLabel = cropViewController.TitleLabel;
                titleLabel.Text = imageCropper.PageTitle;
            }
        }

        public byte[] GetBytes(string imageFile)
        {
            var documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = System.IO.Path.Combine(documentsDirectory, imageFile);
            return System.IO.File.ReadAllBytes(filePath);
        }

        private static async void Finalize(ImageCropper imageCropper, UIImage image)
        {
            string documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string jpgFilename = System.IO.Path.Combine(documentsDirectory, Guid.NewGuid().ToString() + ".jpg");
            NSData imgData = image.AsJPEG();
            NSError err;

            // small delay
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(100));
            if (imgData.Save(jpgFilename, false, out err))
            {
                imageCropper.Success?.Invoke(jpgFilename);
            }
            else
            {
                Debug.WriteLine("NOT saved as " + jpgFilename + " because" + err.LocalizedDescription);
                imageCropper.Failure?.Invoke();
            }
            UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
        }
    }
}