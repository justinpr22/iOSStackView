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

namespace iOSStackView
{
	[Register ("HomeController")]
	partial class HomeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView lblUser { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblUser != null) {
				lblUser.Dispose ();
				lblUser = null;
			}
		}
	}
}
