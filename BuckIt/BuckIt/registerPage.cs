using Foundation;
using System;
using UIKit;

namespace BuckIt
{
    public partial class registerPage : UIViewController
    {
        public registerPage (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            saveRegInfoButton.TouchUpInside += (s, e) =>
            {
                DismissViewController(true, null);

            };

            regCancelButton.TouchUpInside += (s, e) =>
            {
                DismissViewController(true, null);

            };

        }

    }
}