using System;

using AppKit;
using Foundation;

namespace DuplicateDetection
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        //「検出」Buttonクリック時の処理
        partial void detection_button(NSObject sender)
        {
            PerformSegue("MySegue",this);
        }

        // Segueでサブウィンドウが開かれる前に実行されるメソッド
        public override void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
 
            // サブウィンドウのインスタンスを取得
            DetectionViewController sv = segue.DestinationController as DetectionViewController;

            // サブウィンドウのプロパティに値をセット
            sv.TextValue = this.inputText.String;
        }
    }
}
