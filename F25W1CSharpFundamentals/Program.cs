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


            string s1 = "hello";
            string s2 = s1;

            s2 = "bye";
            Console.WriteLine(s1);


            string num = null;
            //int nn = int.Parse(num);
            

            int nn = Convert.ToInt32(num);
            Console.WriteLine(nn);
            Console.WriteLine("\n\n\n");



            double price = 24432.445;
            Console.WriteLine(price.ToString("C"));

            double rate = 0.12;
            Console.WriteLine(rate.ToString("P1"));

            double weight = 4332.3573;
            Console.WriteLine(weight.ToString("F3"));


            int? g = null;
            Console.WriteLine("\n\n\n");




            Person p1 = new Person();
            p1.name = "John";
            Person p2 = p1;

            p2.name = "Anne";
            Console.WriteLine(p1.name);


            //int ii = price as int;
        }
    }

    class Circle
    {
        public int radius;
    }

    class Person
    {
        public string name;
    }
}
