A fork from [stormlion227](https://github.com/stormlion227/ImageCropper.orms). Forked with the intent of making the ImageCropper work with Android 28+. 
Refer to Stormlion's Reop and Nuget package for future updates. 

This package includes iOS10. If there are build issues with iOS 10 please refer to the original repo or submit a PR/issue. 

### Changes include

- updating to Xamarian.Android.28.0.03 and changing package management to a reference style
- Throw some exceptions rather then just silently fail/crash 
- Corrected and update the iOS and Android demos
- Tested on iOS 14.3 
- Await/async added for iOS and Android

Future Ideas: support for UWP, add more errors/exception handling, ability to cleanup cache files

# ImageCropper.Forms

Xamarin.Forms plugin to crop and rotate photos.

[![NuGet](https://img.shields.io/nuget/v/ImageCropper.Forms.svg)](https://www.nuget.org/packages/ImageCropper.Forms/)

Supports Android and iOS.
* Android library from : https://github.com/ArthurHub/Android-Image-Cropper
* iOS library from : https://github.com/TimOliver/TOCropViewController

## Features

* Cropping image.
* Rotating image.
* Aspect ratio.
* Circle/Rectangle shape.

## Screen-Shots

### Android
<img src="ScreenShots/Android_Rectangle.gif" alt="Crop/Rotate image(Rectangle/Android)"/> <img src="ScreenShots/Android_Circle.gif" alt="Crop/Rotate image(Circle/Android)"/>

### iOS
<img src="ScreenShots/iOS_Rectangle.gif" alt="Crop/Rotate image(Rectangle/iOS)"/> <img src="ScreenShots/iOS_Circle.gif" alt="Crop/Rotate image(Circle/iOS)" />

## Setup

* Install the [nuget package]() in portable and all platform specific projects.
* This plugin uses the [MediaPlugin](https://github.com/jamesmontemagno/MediaPlugin/blob/master/README.md). Be sure to complete the full setup this plugin. Please fully read through the [MediaPlugin description](https://github.com/jamesmontemagno/MediaPlugin/blob/master/README.md).

### Android

Add the following to your AndroidManifest.xml inside the <application> tags:
```xml	
	<activity android:name="com.theartofdev.edmodo.cropper.CropImageActivity"
	          android:theme="@style/Base.Theme.AppCompat"/>	
```

In MainActivity.cs file:
```cs
    Stormlion.ImageCropper.Droid.Platform.Init();

    global::Xamarin.Forms.Forms.Init(this, bundle);
```
```cs
    protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
    {
        base.OnActivityResult(requestCode, resultCode, data);

        Stormlion.ImageCropper.Droid.Platform.OnActivityResult(requestCode, resultCode, data);
    }
```

### iOS

In AppDelegate.cs file:

```cs
    Stormlion.ImageCropper.iOS.Platform.Init();
```
## Usage

### Show ImageCropper page.
```cs
    await new ImageCropper()
    {
        Success = (imageFile) =>
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                imageView.Source = ImageSource.FromFile(imageFile);
            });
        }
    }.Show(this);
```
### Show it with additional parameters.
```cs
    await new ImageCropper()
    {
        PageTitle = "Test Title",
        AspectRatioX = 1,
        AspectRatioY = 1,
	CropShape = ImageCropper.CropShapeType.Oval,
	SelectSourceTitle = "Select source",
	TakePhotoTitle = "Take Photo",
	PhotoLibraryTitle = "Photo Library",
	CancelButtonTitle = "Cancel",
        Success = (imageFile) =>
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                imageView.Source = ImageSource.FromFile(imageFile);
            });
        }
    }.Show(this);
```
### Show it with a image
```cs
    await new ImageCropper()
    {
        Success = (imageFile) =>
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                imageView.Source = ImageSource.FromFile(imageFile);
            });
        }
    }.Show(this, imageFileName);
```
### Get byte[] from image file
var imageBytes = ImageCropper.Current.GetBytes(imageFile: imageFile);
### Properties
* PageTitle
* AspectRatioX
* AspectRatioY
* CropShape
* Initial image can be set in Show function.

## Contributions
Contributions are welcome!
