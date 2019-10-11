using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            int counter = 0;

            // loeb mitu a tähte on nimes
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} \"A\"-s in your name");

            Console.ReadLine();

        }
    }
}
