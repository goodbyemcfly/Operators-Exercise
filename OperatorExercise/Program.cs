namespace OperatorExercise
{
    public class Program
    {
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }


        //Assignment #1

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            // Assignment #2

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is " + AreaOfCircle(radius) + "\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
