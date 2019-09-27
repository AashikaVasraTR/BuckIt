using Foundation;
using System;
using UIKit;

namespace BuckIt
{
    public partial class profilePage : UIViewController
    {
        public profilePage(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            logoutButton.TouchUpInside += (s, e) =>
            {
                DismissViewController(true, null);

            };
        }
    }
}