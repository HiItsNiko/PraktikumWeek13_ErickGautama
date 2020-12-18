using System;

namespace teset3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello world";
            char[] b = a.ToCharArray();
            Array.Sort(b);
           
                Console.Write(b);
            
        }
    }
}
