using System;

namespace DelegatesPractice
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);
        public delegate string GreetNameDelegate(string name);
        static void Main(string[] args)
        {
            PerformCalculation getSum = Calculation.Add;
            PerformCalculation getSubtraction = Calculation.Sub;
            PerformCalculation getMultiply = Calculation.Multiply;
            PerformCalculation getDivision = Calculation.Divide;

            // call delegates one buy one
            getSum(1, 2);
            getSubtraction(1, 2);
            getMultiply(1, 2);
            getDivision(1, 2);
            getDivision(1, 0);

            // multicast delegate
            PerformCalculation multicastDelegate = Calculation.Add; //Add directly function
            multicastDelegate += getSubtraction + getMultiply + getDivision; // Add other delegates
            multicastDelegate -= Calculation.Multiply; // Add or remove functions directly
            double result = multicastDelegate(5, 3); // you can run mutiple function at once with muticast delegate
            Console.WriteLine($"You only get the return of the last delegate (division in this case): {result}");

            // Anonymous functions using delegates
            GreetNameDelegate greetName = delegate(string name)
            {
                return "Hi " + name + "!";
            };
            string greeting = greetName("Amir");
            Console.WriteLine(greeting);
            DisplayMessage(greetName);

            // Lambda function
            GreetNameDelegate greetNameLambda = (string name) => { return "Hello from lambda dear " + name + "!"; };
            Console.WriteLine(greetNameLambda("Amir"));

        }

        // Function that accepts a delegate
        public static void DisplayMessage(GreetNameDelegate del)
        {
            Console.WriteLine("Display message invokes a delegate: " + del("world"));
        }
    }
}
