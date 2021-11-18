using System;

namespace wordslist
{
    class Program
    {
        static void Main(string[] args)
        {
            //first arg position will be consider the number of letters for the length of the word
            int wordLength = Validation.InvalidateString(args[0]) ? Convert.ToInt32(args[0]) : Enum.StaticNumbers.DefaultWordsLength;

            ProcessingWords.FindTheWords(new WordsList { wordLength = wordLength });

            Console.WriteLine("Words loaded! " + DateTime.Now.ToString("F"));
        }
    }
}
