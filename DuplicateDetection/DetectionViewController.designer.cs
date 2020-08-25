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
	[Register ("DetectionViewController")]
	partial class DetectionViewController
	{
		[Outlet]
		AppKit.NSTextView detectionText1 { get; set; }

		[Outlet]
		AppKit.NSTextView detectionText2 { get; set; }

		[Action ("sortMenu:")]
		partial void sortMenu (Foundation.NSObject sender);

		[Action ("sortMenu1:")]
		partial void sortMenu1 (Foundation.NSObject sender);

		[Action ("sortMenu2:")]
		partial void sortMenu2 (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (detectionText1 != null) {
				detectionText1.Dispose ();
				detectionText1 = null;
			}

			if (detectionText2 != null) {
				detectionText2.Dispose ();
				detectionText2 = null;
			}
		}
	}
}
