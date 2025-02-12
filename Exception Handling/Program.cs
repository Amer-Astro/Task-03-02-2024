using System.Linq;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exeption1();

            //Exeption2();

        }

        static void Exeption1()
        {
            Console.Write($"Enter Array lenth: ");
            int arrayLingh = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLingh];

            for (int i = 0; i < arrayLingh; i++)
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

        static void Exeption2()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Enter the string: ");

            string input = Console.ReadLine();

            for (int i = 0; input.Length >= i; i++) 
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