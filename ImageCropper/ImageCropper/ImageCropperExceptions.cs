using System;
using System.Collections.Generic;
using System.Text;

namespace Stormlion.ImageCropper
{
    //TODO Work on adding some exceptions for if somethiwng fails but some 
    // of this will depend on the Failure Action in ImageCropper.cs
    
    public class CameraIsNotAvailableException : Exception
    {
        public CameraIsNotAvailableException() {} 

        public CameraIsNotAvailableException(string message) : base(message) {}
    }

    public class PhotoPickingIsNotAvailable : Exception
    {
        public PhotoPickingIsNotAvailable() {} 

        public PhotoPickingIsNotAvailable(string message) : base(message) {}
    }

    public class InputtedImageFileBranchingFailure: Exception
    {
        public InputtedImageFileBranchingFailure() {} 

        public InputtedImageFileBranchingFailure(string message) : base(message) {}
    }
}
