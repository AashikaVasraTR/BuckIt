// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BuckIt
{
    [Register ("similarInterestsPage")]
    partial class similarInterestsPage
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton backToProfileButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (backToProfileButton != null) {
                backToProfileButton.Dispose ();
                backToProfileButton = null;
            }
        }
    }
}