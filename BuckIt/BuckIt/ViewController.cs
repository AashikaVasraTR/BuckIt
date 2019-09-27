using Foundation;
using System;
using UIKit;

namespace BuckIt
{
    public partial class ViewController : UIViewController
    {


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            loginButton.TouchUpInside += (s, e) =>
            {
                profilePage profilePageVC = Storyboard.InstantiateViewController ("profilePage") as profilePage;
                PresentViewController(profilePageVC, true, null);


            };

            registerButton.TouchUpInside += (s, e) =>
            {
                registerPage registerPageVC = Storyboard.InstantiateViewController("registerPage") as registerPage;
                PresentViewController(registerPageVC, true, null);


            };


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}