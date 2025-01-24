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
        }
    }
}
