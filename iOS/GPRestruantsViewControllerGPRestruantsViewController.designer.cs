// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TestDemo.iOS
{
    [Register ("GPRestruantsViewControllerGPRestruantsViewController")]
    partial class GPRestruantsViewControllerGPRestruantsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblRestruants { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (tblRestruants != null) {
                tblRestruants.Dispose ();
                tblRestruants = null;
            }
        }
    }
}