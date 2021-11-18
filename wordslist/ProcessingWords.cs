using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace wordslist
{
    public class ProcessingWords
    {
        public ProcessingWords()
        {
        }

        public static void FindTheWords(WordsList wordProcess)
        {
            wordProcess.listOfWords = File.ReadAllLines(Enum.StaticNames.TextFileInput);

            File.WriteAllLines(DateTime.Now.ToString("MMddyyyyHHmmss") + Enum.StaticNames.TextFileOutput, ConcatenateString(wordProcess.listOfWords, wordProcess.wordLength).Cast<string>());
        }

        private static string[] ConcatenateString(string[] stringArray, int wordLength)
        {
            List<string> arlist = new();

            for (int i = 0; i <= stringArray.Length; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    var fb = new StringBuilder();
                    fb.Append(stringArray[i]);
                    fb.Append(stringArray[j]);

                    string result = fb.ToString();
                    if (result.Length == wordLength)
                        arlist.Add(result);
                }
            }

            string[] list = (from word in arlist
                             where word == stringArray.FirstOrDefault(item => item == word)
                             select word).ToArray();

            return list;
        }
    }
}
