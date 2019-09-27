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
    [Register ("registerPage")]
    partial class registerPage
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton regCancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regInt1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regInt2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regInt3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField regZipcode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton saveRegInfoButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (regCancelButton != null) {
                regCancelButton.Dispose ();
                regCancelButton = null;
            }

            if (regEmail != null) {
                regEmail.Dispose ();
                regEmail = null;
            }

            if (regInt1 != null) {
                regInt1.Dispose ();
                regInt1 = null;
            }

            if (regInt2 != null) {
                regInt2.Dispose ();
                regInt2 = null;
            }

            if (regInt3 != null) {
                regInt3.Dispose ();
                regInt3 = null;
            }

            if (regName != null) {
                regName.Dispose ();
                regName = null;
            }

            if (regPassword != null) {
                regPassword.Dispose ();
                regPassword = null;
            }

            if (regZipcode != null) {
                regZipcode.Dispose ();
                regZipcode = null;
            }

            if (saveRegInfoButton != null) {
                saveRegInfoButton.Dispose ();
                saveRegInfoButton = null;
            }
        }
    }
}