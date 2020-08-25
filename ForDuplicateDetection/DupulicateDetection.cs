using System;
using System.Collections.Generic;
using System.Linq;

namespace ForDuplicateDetection
{
    public class DuplicateDetection
    {
        public string TextValue
        {
            get;
            set;
        }

        public string Detection(bool flag)
        {
            string[] del = { "\n" };
            string[] arr = this.TextValue.Split(del, StringSplitOptions.None);

            var wordList = new List<string>();
            wordList.AddRange(arr);

            if(flag == false)
            {
                var noduplicate = wordList.Distinct().ToList();
                var detectionText = String.Join("\n", noduplicate);

                return detectionText;
            }
            else if(flag == true)
            {
                var duplicates = wordList.GroupBy(name => name).Where(name => name.Count() > 1).Select(group => group.Key).ToList();
                var detectionText = String.Join("\n", duplicates);

                return detectionText;
            }

            return null;
        }

        public string NoDuplication()
        {
            //falseを引数としてメソッドDetectionに渡すことで、重複していない文字を取得して返す
            return Detection(false);
        }

        public string Duplication()
        {
            //trueを引数としてメソッドDetectionに渡すことで、重複している文字を取得して返す
            return Detection(true);
        }
    }
}
