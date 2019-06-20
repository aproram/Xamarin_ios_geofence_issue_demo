// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Geofencing
{
    [Register ("GeofencingViewController")]
    partial class GeofencingViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button { get; set; }


        [Action ("UIButton1_TouchUpInside:")]
        partial void UIButton1_TouchUpInside (UIKit.UIButton sender);

        [Action ("buttonCreateClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void buttonCreateClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (button != null) {
                button.Dispose ();
                button = null;
            }
        }
    }
}