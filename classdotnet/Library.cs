using System;

namespace classdotnet
{
    public class Library<T>
    {
        double a, b, temp;
        public T Add(T value1, T value2)
        {
            
            a = Convert.ToDouble(value1);
            b = Convert.ToDouble(value2);
            temp = a + b;
            return (T)Convert.ChangeType(temp, typeof(T));
        }
        public T Sub(T value1, T value2)
        {
           
            a = Convert.ToDouble(value1);
            b = Convert.ToDouble(value2);
            temp = a - b;
            return (T)Convert.ChangeType(temp, typeof(T));
        }
        public T Mul(T value1, T value2)
        {
           
            a = Convert.ToDouble(value1);
            b = Convert.ToDouble(value2);
            temp = a * b;
            return (T)Convert.ChangeType(temp, typeof(T));
        }
        public double Div(T value1, T value2)
        {

           
            a = Convert.ToDouble(value1);
            b = Convert.ToDouble(value2);
            if (b == 0)
            {
                Console.WriteLine("Denominator can't be zero_ DivideByZeroException");
                return 0;
            }
            else
            {
                return (a / b);
            }
        }
            
        public double Addninp(params double[] numbers)
        { 
                double sum = 0;
                foreach (double i in numbers)
                {
                    sum += i;
                }
            return sum;
             
        }
    } 

}

    

