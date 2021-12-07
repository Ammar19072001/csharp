using System;
namespace hell
{
    class program 
    {
        public static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter any Varb");
            character = Convert.ToChar(Console.ReadLine().ToLower());
            switch(character)
            {
                case 'a':
                Console.WriteLine("This is a Vowel");
                break;
                case 'e':
                Console.WriteLine("This is a Vowel");
                break;
                case 'i':
                Console.WriteLine("This is a Vowel");
                break;
                case 'o':
                Console.WriteLine("This is a Vowel");
                break;
                case 'u':
                Console.WriteLine("This is a Vowel");
                break;
                default:
                Console.WriteLine("This is a Constant");
                break;

            }
        }
    }    
}