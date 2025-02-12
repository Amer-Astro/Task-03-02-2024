using System.Linq;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exception1();

            //Exception2();

        }

        static void Exception1()
        {
            Console.Write($"Enter Array length: ");
            int arraylength = int.Parse(Console.ReadLine());

            int[] array = new int[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                Console.Write($"Enter index number {i + 1}: ");
                int index = int.Parse(Console.ReadLine());

                if (array.Contains(index))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("This index already exist");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                array[i] = index;
            }
            foreach (var Arr in array)
            {
                Console.WriteLine(Arr);
            }
        }

        static void Exception2()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Enter the string: ");

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++) 
            {
                if (vowels.Contains(input[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("This Input has Vowels");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.WriteLine($"input is {input} and it has no Vowels on it");
        }
    }
}