using System.IO;

namespace C__basic_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowNumber;
            int highNumber;
            int Differance;
            /* prompt user to enter low number*/
            Console.Write("Enter a low number: ");
            lowNumber = Convert.ToInt32(Console.ReadLine());

            /*Prompt user to enter high number */
            Console.WriteLine();
            Console.Write("Enter a high number: ");
            highNumber = Convert.ToInt32(Console.ReadLine());

            Differance = highNumber - lowNumber;
            Console.WriteLine($"{Differance} is the differance between the low and high number");

            while (lowNumber < 0)
            {
                Console.Write("Enter a low number That is positive: ");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            }
            while (highNumber < lowNumber)
            {
                Console.Write("Enter a number greater then the low number: ");
                highNumber = Convert.ToInt32(Console.ReadLine());
            }

            int index = 0;
            int[] array = new int[Differance - 1];
            for (int i = lowNumber + 1; i < highNumber; i++)
            {
                array[index] = i;
                index++;
            }
            Array.Sort(array, (x, y) => y.CompareTo(x));

            string filePath = "numbers.txt";

            File.WriteAllLines(filePath,array.Select(x => x.ToString()));






        }
        
    }
}
