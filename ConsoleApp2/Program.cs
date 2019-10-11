using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string name;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            int counter = 0;

            // loeb igat elementi
            foreach(char letter in name)
            {
                counter++;
            }

            Console.WriteLine($"Your name is {counter} letters long");

            Console.ReadLine();
            */

            string name;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            bool letterFound = false;

            foreach (char letter in name)

                if (letter == 'a')
                {
                    
                    letterFound = true;
                }


            //esimene variant
            /*if(letterFound)
            {
                Console.WriteLine("Your name contains A");
            }


            else
            {
                Console.WriteLine("Your name dont contain A");
                
            }*/

            //teine variant
            string result = letterFound ? "Includes an A" : "Dond include an A";
            Console.WriteLine(result);


            Console.ReadLine();





        }
    }
}
