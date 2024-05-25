using System;
using System.Text;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result1 = ConcatenatingStrings("How", " are you?");
            Console.WriteLine(result1);
            CheckResult("How are you?", result1);


            string result2 = GreetUser("John", 30);
            Console.WriteLine(result2);
            CheckResult("Hello, John!\nYou are 30 years old.", result2);

            string result3 = NumberSymbols("Good morning!");
            Console.WriteLine(result3);
            CheckResult("13GOOD MORNING!good morning!", result3);

            string result4 = FirstFiveSymbols("The grass is green, the sky is grey");
            Console.WriteLine(result4);
            CheckResult("The g", result4);

            string[] sentence = { "How", "are", "you" };

            var result5 = ArrayToSentence(sentence);
            Console.WriteLine(result5.ToString());
            CheckResult("How are you ", result5.ToString());

            string result6 = ReplaceWords("Hi, everyone", "everyone", "you");
            Console.WriteLine(result6);
            CheckResult("Hi, you", result6);

            Console.ReadLine();
        }

        //1
        public static string ConcatenatingStrings(string string1, string string2)
        {
            var result = string1 + string2;
            return result;
        }

        //2
        public static string GreetUser(string name, int age)
        {
            string result = $"Hello, {name}!\nYou are {age} years old.";
            return result;
        }

        //3
        public static string NumberSymbols(string str)
        {
            string upperString = str.ToUpper();
            string lowerString = str.ToLower();
            int stringLength = str.Length;

            string result = $"{stringLength}{upperString}{lowerString}";
            return result;
        }

        //4
        public static string FirstFiveSymbols(string str)
        {
            string result = str.Substring(0, 5);
            return result;
        }

        //5
        public static StringBuilder ArrayToSentence(string[] stringArray)
        {
            var builder = new StringBuilder();
            foreach (var str in stringArray)
            {
                builder.Append(str);
                builder.Append(" ");
            }
            return builder;
        }

        //6
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            if (inputString.Contains(wordToReplace))
            {
                string result = inputString.Replace(wordToReplace, replacementWord);
                return result;
            }
            else
            {
                return "Word is not found";
            }
        }

        public static bool CheckResult(string desiredResult, string result)
        {
            if (desiredResult == result)
            {
                Console.WriteLine("Method works correctly");
                return true;
            }
            else
            {
                Console.WriteLine("Method must be corrected");
                return false;
            }
        }
    }
}
