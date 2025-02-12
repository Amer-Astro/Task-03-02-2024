namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter Array lenth: ");
            int arrayLingh = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLingh];

            for (int i = 0; i < arrayLingh; i++) 
            {
                Console.Write($"Enter index number {i+1}: ");
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
    }
}