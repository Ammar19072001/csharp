using System;
namespace hell
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if(a>0)
            {
                Console.WriteLine("The value is Postive");
            }
            else if(a<0)
            {
                Console.WriteLine("The value is Negative");
            }
            else if(a==0)
            {
                Console.WriteLine("The Value is Zero");
            }
        }
    }
}