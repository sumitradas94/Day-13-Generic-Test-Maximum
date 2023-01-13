namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");
            //int X = 20;
            //int Y = 400;
            // int Z = 6000;

            //int val = MaxInteger<int>.MaxIntNumber(X, Y, Z);
            //Console.WriteLine("The greater num is " + val);

            //float A = 40.5F;
            // float B = 50.6F;
            //float C = 80.9F;

            //float val = MaxFloat<float>.MaxFloatNum(A, B, C);
            //Console.WriteLine("The greater Float Num  is " + val);

            //string L = "Red";
            // string M = "Yellow";
            // string N = "Purple";

            // string val2 = MaxString<string>.MaxStringNum(L, M, N);
            //Console.WriteLine("The greater String is " + val2);

            Max3Parameter<int> obj = new Max3Parameter<int>(66, 99, 92);
            obj.MaxMethod();
        }
}
}