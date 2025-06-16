using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CountingElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ты ты ты, да мы с тобой.";

            foreach (var pair in GetWordsCount(text))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }

        public static Dictionary<string, int> GetWordsCount(string sentence)
        {
            var words = sentence.Split(new[] { ' ', ',', '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();

                if (wordCount.ContainsKey(lowerWord))
                {
                    wordCount[lowerWord]++;
                }
                else
                {
                    wordCount[lowerWord] = 1;
                }
            }
            return wordCount;
        }
    }
}
            

        
    
