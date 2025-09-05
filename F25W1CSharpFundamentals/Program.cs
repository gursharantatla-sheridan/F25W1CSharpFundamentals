namespace F25W1CSharpFundamentals
{
    internal class Program
    {
        static int n;

        static void Main(string[] args)
        {
            int @double = 5;
            //int n;

            int m = n + 10;

            //int i = 5;
            double d = 5.5;

            float f = 5.5F;
            decimal mm = 5.5M;
            long l = 435324324L;

            var x = 5;

            Console.WriteLine("hello\nworld");



            int a = 5, b = 3, c = 8;

            // string concatenation
            Console.WriteLine("a = " + a + ", b = " + b + " and c = " + c);

            // string interpolation
            Console.WriteLine($"a = {a}, b = {b} and c = {c}");

            Console.WriteLine("\n\n\n");



            int i = 5;
            int j = i;

            i++;
            Console.WriteLine(j);


            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);
            c1.radius = 20;
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            c2.radius = 60;
            Console.WriteLine(c1.radius);
        }
    }

    class Circle
    {
        public int radius;
    }
}
