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

		[Outlet]
		AppKit.NSTextField wordsCount { get; set; }
		
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

			if (wordsCount != null) {
				wordsCount.Dispose ();
				wordsCount = null;
			}
		}
	}
}
