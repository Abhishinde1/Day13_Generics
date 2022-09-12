namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 50; int c = 30;

            Console.WriteLine("________________MAX NUMBER_______________");
            Console.WriteLine("Max number is " + MaxNumber<int>.printMaximumNumbers(a, b, c));



            Console.WriteLine("________________MAX FLOAT_______________");
            float x = 10.2F; float y = 50.2F; float z = 30.3F;
            Console.WriteLine("Max number is " + MaxFloat<float>.printMaximumNumbers(x, y, z));


            Console.WriteLine("____________MAX STRING PROGRAM_______________");
            Console.WriteLine("max string number is " + MaxString<string>.printMaximumNumbers("a", "ab", "abc"));


            Console.WriteLine("_____________REFACTOR______________");
            Refactor obj = new Refactor();
            Console.WriteLine("max refactor num is " + obj.Max<string>("abhi", "Shinde", "abhishinde"));
            Console.WriteLine("max refactor num is " + obj.Max<int>(1 , 45 , 55));


        }
    }
    
}