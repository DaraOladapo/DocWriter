using System.Collections.Generic;
using System.Linq;
using System.IO;

using AppKit;
using Foundation;

namespace DocWriter
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		List<MainWindowController> windows = new List<MainWindowController> ();

		public override void DidFinishLaunching (NSNotification notification)
		{
			NSUserDefaults.StandardUserDefaults.SetBool (true, "WebKitDeveloperExtras");
			NSUserDefaults.StandardUserDefaults.Synchronize ();

			var dirs = NSUserDefaults.StandardUserDefaults.StringArrayForKey ("LoadedDirectories");
			if (dirs != null && dirs.Length > 0) {
				foreach (var d in dirs.Distinct ().Where (x=>File.Exists (x))) {
					OpenDir (d);
				}
				if (windows.Count == 0)
					OpenDialog (this);
			} else 
				OpenDialog (this);

			NSWindow.Notifications.ObserveWillClose ((a,b)=>{
				var target = b.Notification.Object as MainWindow;

				if (target != null){
					windows.Remove ((target.WindowController) as MainWindowController);
					SaveStatus ();
				}
			});
		}

		bool quitting;
		public override void WillTerminate (NSNotification notification)
		{
			foreach (var wc in windows) {
				wc.EditorWindow.SaveCurrentObject ();
			}
			SaveStatus ();
			quitting = true;
		}

		// Saves the list of open windows
		//
		void SaveStatus ()
		{
			if (quitting)
				return;
			NSUserDefaults.StandardUserDefaults ["LoadedDirectories"] = NSArray.FromStrings (windows.Select (wc => wc.EditorWindow.WindowPath).ToArray ());
		}

		//
		// Creates a new editing window pointing to a directory
		//
		void OpenDir (string dir)
		{
			var controller = new MainWindowController (dir);
			controller.Window.MakeKeyAndOrderFront (this);
			windows.Add (controller);
		}

		//
		// File open dialog
		//
		[Export ("openDocument:")]
		void OpenDialog (NSObject sender)
		{
			var dlg = NSOpenPanel.OpenPanel;
			dlg.CanChooseFiles = false;
			dlg.CanChooseDirectories = true;

			if (dlg.RunModal () == 1) {
				var url = dlg.Urls.FirstOrDefault ();
				if (url != null) {
					var path = url.Path;

					if (Directory.Exists (Path.Combine (path, "en")) && File.Exists (Path.Combine (path, "en", "index.xml"))) {
						OpenDir (Path.Combine (path, "en"));
						SaveStatus ();
					} else {
						var alert = new NSAlert () {
							AlertStyle = NSAlertStyle.Critical,
							InformativeText = "The selected directory is not the toplevel directory for ECMA XML documentation.   Those should contain a subdirectory en and a file en/index.xml",
							MessageText = "Not an ECMA XML Documentation Directory",
						};
						alert.RunModal ();
					}
				}
			}

		}
	}
}

