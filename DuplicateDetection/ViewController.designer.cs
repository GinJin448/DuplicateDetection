// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DuplicateDetection
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextView inputText { get; set; }

		[Action ("detection_button:")]
		partial void detection_button (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (inputText != null) {
				inputText.Dispose ();
				inputText = null;
			}
		}
	}
}
