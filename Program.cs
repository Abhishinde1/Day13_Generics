namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 50; int c = 30;


            Console.WriteLine("Max number is " + MaxNumber<int>.printMaximumNumbers(a, b, c));

        }
    }
}