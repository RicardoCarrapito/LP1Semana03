using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("String:");
            string str =Console.ReadLine();
            Console.WriteLine("Caráter:");
            string ctr=Console.ReadLine();
            char carater=char.Parse(ctr);

            foreach(char l in str)
            {
                if(carater==l)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(l);
                }
            }

        }
    }
}
