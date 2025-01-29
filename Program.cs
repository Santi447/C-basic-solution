using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace C__basic_solution
{
    internal class Program
    {

        public static bool PrimeNumberValidator(int number)
        {
            if(number < 1) return false;
            if (number == 2) return true;
            if(number %2 == 0 && number > 2) return false;
            if (number %2 == 1 && number > 2)
            {
                int sqr = Convert.ToInt32(Math.Sqrt(number));
                
                for(int i = 3; i <= sqr; i++)
                {
                    if (number % i == 0) return false;                 

                    
                }
            }
            return true;

        }
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


            int total=0;
            string[] fileContents = File.ReadAllLines(filePath);
           
            for (int i = 0; i < fileContents.Length; i++)
            {

                total += Convert.ToInt32(fileContents[i]);

            }

            Console.WriteLine($"The sum of numbers in file: {total}");
            List<double> numbers = new List<double>();
            foreach (string content in fileContents)
            {
                if (double.TryParse(content, out double number))
                {
                    numbers.Add(number);
                }
            }


            foreach (int i in numbers)
            {
              if (PrimeNumberValidator(i))
                {
                   Console.WriteLine("The Prime numbers from the numbers in the final are");
                    Console.WriteLine(i); 
                }

            }

           








        }
        
    }
}
