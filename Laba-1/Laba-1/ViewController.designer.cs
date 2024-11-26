// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Laba1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton DeleteBtn { get; set; }

		[Outlet]
		AppKit.NSButton DownBtn { get; set; }

		[Outlet]
		AppKit.NSTableView TAb { get; set; }

		[Outlet]
		AppKit.NSButton UpBtn { get; set; }

		[Action ("AddButton:")]
		partial void AddButton (Foundation.NSObject sender);

		[Action ("CancelButhon:")]
		partial void CancelButhon (Foundation.NSObject sender);

		[Action ("DeleteButton:")]
		partial void DeleteButton (Foundation.NSObject sender);

		[Action ("DownButton:")]
		partial void DownButton (Foundation.NSObject sender);

		[Action ("SendButton:")]
		partial void SendButton (Foundation.NSObject sender);

		[Action ("UpButton:")]
		partial void UpButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DeleteBtn != null) {
				DeleteBtn.Dispose ();
				DeleteBtn = null;
			}

			if (DownBtn != null) {
				DownBtn.Dispose ();
				DownBtn = null;
			}

			if (TAb != null) {
				TAb.Dispose ();
				TAb = null;
			}

			if (UpBtn != null) {
				UpBtn.Dispose ();
				UpBtn = null;
			}
		}
	}
}
