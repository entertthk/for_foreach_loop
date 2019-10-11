using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tyhik
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();


            //foreach
            /*foreach(char letter in name)
            {
                Console.Write($"{letter} ");
            }
            */


            //for loop
            for (int i = 0; i < name.Length; i++)
            {
                if (i == name.Length-1)
                {
                    Console.Write($"{name[i]}");
                    break;
                }
                Console.Write($"{name[i]}*");

            }

            //kodus teha see while loopiga<----------------------- iga tähe vahele tärn ja viimane ilma tärnita

            Console.ReadLine();
        }
    }
}
