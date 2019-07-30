using System;

namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            classdotnet.Library<int> obj = new classdotnet.Library<int>();
            
            Console.WriteLine(">NET Core.....Enter two integers");
             a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: "+obj.Add(a,b));
            Console.WriteLine("Subtraction: " + obj.Sub(a, b));  
            Console.WriteLine("Multiplication: "+obj.Mul(a,b));
            Console.WriteLine("Division: " + obj.Div(a, b));
             Console.WriteLine(obj.Addninp(12, 23, 76, 45,15.6));

            double d, c;
            classdotnet.Library<double> obj1 = new classdotnet.Library<double>();

            Console.WriteLine(">NET Core.....Enter two Double Values");
            d = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition: " + obj1.Add(d,c));
            Console.WriteLine("Subtraction: " + obj1.Sub(d,c));
            Console.WriteLine("Multiplication: " + obj1.Mul(d,c));
            Console.WriteLine("Division: " + obj1.Div(d,c));
            Console.WriteLine(obj.Addninp(12, 23, 76, 45, 15.6));

            Console.ReadLine();

        }
    }
}
