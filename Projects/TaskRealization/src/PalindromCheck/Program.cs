namespace PalindromCheck
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PalindromChecker checker = new PalindromChecker();
            PalindromChecker checker1 = new PalindromChecker();

            string value = "топот";

            if (checker.CheckPalindrom(value))
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }

            Console.WriteLine(value.Equals("топот"));
            Console.WriteLine(!checker.Equals(checker1));

            Console.WriteLine(checker.ToString());

            checker.CheckPalindrom(1);
            string[] massive = { "1", "a", "b", "@@" };

            checker.CheckPalindrom("топот", massive);
        }
    }
}