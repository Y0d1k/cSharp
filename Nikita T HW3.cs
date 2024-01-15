namespace Nikita_T._Hillel_HW3
{
    internal class Program
    {
        /*
         * This is from the linear eqaution task that you gave us some time ago in lms chat
         * Now it's updated with method TakingCoefficient
         */
        static double TakingCoefficient(char nameOfCoef)
        {
            Console.Write($"Please enter the {nameOfCoef} parameter of linear system: ");
            return double.Parse(Console.ReadLine());
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(@"Here's how the linear function will look like: 
{ax+by=c
{dx+ey=f");
            var a = TakingCoefficient('A');
            var b = TakingCoefficient('B');
            var c = TakingCoefficient('C');
            var d = TakingCoefficient('D');
            var e = TakingCoefficient('E');
            var f = TakingCoefficient('F');
            var x = c / a - b / a * (a * f - d * c) / (a * e - d * b);
            var y = (a * f - d * c) / (a * e - d * b);
            Console.WriteLine(@$"The x you were looking for is: {x}
And the y is: {y}");
        }
    }
}

