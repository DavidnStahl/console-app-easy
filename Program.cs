using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liketocode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you like to program? ");
            string anwser = Console.ReadLine();

            if (anwser == "yes")
            {
                Console.WriteLine("Fun to hear :-).");
            }
            else
            {
                Console.WriteLine("Fight anyway!");
            }
            Console.ReadLine();
            //If the answer is "Yes", the program should show: "Fun to hear :-)."
            //Otherwise, the program should show: "Fight anyway!"
        }
    }
}
