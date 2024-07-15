using System.Threading.Channels;

namespace MethodOverloading
{
    public class Program
    {
        /* 1. Done  Create a method named Add, that accepts two integers and returns the sum of those two integers
           2. Done  Now create an overload of the Add method to account for being able to add two decimals together
           3. Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
           If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
           You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”*/
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static decimal Add(decimal firstDecimal, decimal secondDecimal)
        {
            return firstDecimal + secondDecimal;
        }


        public static string Add(int first, int second, bool isCurrency)
        {
            if (isCurrency && first + second == 1)
            {
                Console.WriteLine($"{first + second} dollar");
            }
            else if( isCurrency && first + second > 1)
            {
                Console.WriteLine($"{first + second} dollars");
            }
            else if(!isCurrency)
            {
                Console.WriteLine($"{first + second}");
            }
            else
            {
                Console.WriteLine($"{first + second} dollars: You have no money");
            }

            return "Done";
        }
        static void Main(string[] args)
        {
            var x = 1;
            var y = 2;

            var a = 2.2m;
            var b = 2.2m;
            
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(a, b));
            Add(0, 2, true);
        }
    }
}
