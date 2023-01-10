namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");
            int X = 20;
            int Y = 400;
            int Z = 6000;

            int val = MaxInteger<int>.MaxIntNumber(X, Y, Z);
            Console.WriteLine("The greater num is " + val);
        }
    }
}