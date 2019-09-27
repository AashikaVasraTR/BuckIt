using Foundation;
using System;
using UIKit;

namespace BuckIt
{
    public partial class similarInterestsPage : UIViewController
    {
        public similarInterestsPage (IntPtr handle) : base (handle)
        {
        }

        backToProfileButton.TouchUpInside += (s, e) =>
            {
                DismissViewController(true, null);

    };

}
}