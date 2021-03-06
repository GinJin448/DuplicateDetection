﻿using System;
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

        public string WordsCount
        {
            get;
            set;
        }

        private string Detection(bool flag)
        {
            int fullCount = 0;
            int count = 0;
            string[] arr = this.TextValue.Split("\n", StringSplitOptions.None);

            var wordList = new List<string>();
            var duplicates = new List<string>();
            wordList.AddRange(arr);
            fullCount = wordList.Count();

            if (flag == false)
            {
                duplicates = wordList.Distinct().ToList();
                count = duplicates.Count();
                this.WordsCount = fullCount.ToString() + "語から" + count.ToString() + "単語を抽出し、";
            }
            else if (flag == true)
            {
                duplicates = wordList.GroupBy(name => name).Where(name => name.Count() > 1).Select(group => group.Key).ToList();

                var noDuplicate = new List<string>();
                noDuplicate = wordList.Distinct().ToList();

                count = wordList.Count() - noDuplicate.Count();
                this.WordsCount += "計" +count.ToString() + "語の";
                
                count = duplicates.Count();
                this.WordsCount += count.ToString() + "単語の重複を検出しました。";

                for (int i = 0; i < duplicates.Count(); i++)
                {
                    count = -1;
                    foreach(string text2 in wordList)
                    {
                        if(duplicates[i] == text2)
                        {
                            count++;
                        }
                    }
                    duplicates[i] += ", " + count.ToString() + "個の重複";
                }
            }
            var detectionText = String.Join("\n", duplicates);

            return detectionText;
        }

        public string NoDuplication()
        {
            //falseを引数としてメソッドDetectionに渡して、重複していない文字を取得して返す
            return Detection(false);
        }

        public string Duplication()
        {
            //trueを引数としてメソッドDetectionに渡して、重複している文字を取得して返す
            return Detection(true);
        }
    }
}