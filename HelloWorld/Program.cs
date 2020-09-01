using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //this is a commentary
            // Console.WriteLine("Hello Janika!");
            /* 1. The program ask the user´s name 
             * 2. The user enters their name 
             * 3. The program greets the user by their name*/
            Console.WriteLine("What`s your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);



        }
    }
}
