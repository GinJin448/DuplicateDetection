// This file has been autogenerated from a class added in the UI designer.

using System;
using System.IO;
using System.Linq;

using Foundation;
using AppKit;

using ForDuplicateDetection;

namespace DuplicateDetection
{
    public partial class DetectionViewController : NSViewController
    {
        public string TextValue
        {
            get;
            set;
        }

        public DetectionViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var detection = new ForDuplicateDetection.DuplicateDetection();
            detection.TextValue = this.TextValue;

            // 重複していない値をdetectionText1にセット
            this.detectionText1.Value = detection.NoDuplication();

            if (this.detectionText1.Value.Length == 0)
            {
                this.detectionText1.Value = "何も入力されていません。";
            }

            // 重複している値をdetectionText2にセット
            this.detectionText2.Value = detection.Duplication();

            if (this.detectionText2.Value.Length == 0)
            {
                this.detectionText2.Value = "重複している文字はありません。";
            }

            if (detection.TextValue.Length > 0)
            {
                this.wordsCount.StringValue = detection.WordsCount;
            }
        }
    }
}