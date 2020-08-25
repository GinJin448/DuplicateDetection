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

            string[] del = { "\n" };
            string[] arr = this.TextValue.Split(del, StringSplitOptions.None);

            int count = arr.Count();

            detection.TextValue = this.TextValue;

            if (detection.TextValue.Length > 0)
            {
                detection.WordsCount = count.ToString() + "語";
            }
            Console.WriteLine(detection.WordsCount);

            // メインウィンドウから受け取った値を外部ライブラリForDuplicateDetectionに渡し、重複していない値をTextViewにセット
            this.detectionText1.Value = detection.NoDuplication();

            if (this.detectionText1.Value.Length == 0)
            {
                this.detectionText1.Value = "何も入力されていません。";
            }
            Console.WriteLine(detection.WordsCount);

            // メインウィンドウから受け取った値を外部ライブラリForDuplicateDetectionに渡し、重複している値をTextViewにセット
            this.detectionText2.Value = detection.Duplication();

            if (this.detectionText2.Value.Length == 0)
            {
                this.detectionText2.Value = "重複している文字はありません。";
            }
            Console.WriteLine(detection.WordsCount);

            if (detection.TextValue.Length > 0)
            {
                this.wordsCount.StringValue = detection.WordsCount;
            }
        }
    }
}