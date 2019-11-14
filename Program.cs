using System;

namespace BasicPart02_InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            Console.Write("Input your birthyear: ");
            int result;
            int.TryParse(Console.ReadLine(), out result);
            result = result + 543;
            Console.WriteLine("My name is : " + name);
            Console.WriteLine("My birthday is " + result);
           
            Console.ReadKey();
        }
    }
}
