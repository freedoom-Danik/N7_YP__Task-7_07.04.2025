namespace N7_YP__Task_7_07._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("input String ");
            string input = Console.ReadLine();

            Console.Write("input i ");
            int i = int.Parse(Console.ReadLine());
            
            Console.Write("input j ");
            int j = int.Parse(Console.ReadLine());

            if (i < 0 || j >= input.Length || i > j)
            {
                Console.WriteLine("incorrect index ");
                return;
            }

            string result = input.Remove(i , j - i + 1);
            Console.WriteLine($"{result}");
        }
    }
}
