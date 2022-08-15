using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_Counter
{
    internal class Program
    {
        static int Main(string[] args)
        {
            string line;
            string file = "ReadMe.txt";

            StreamReader myfile = new StreamReader(file);

            int count = 0;

            while (myfile.EndOfStream == false)
            {
                line = myfile.ReadLine();
              
                for (int i = 0; i < 6; i++)
                {
                    if (line.EndsWith("e")|| line.EndsWith("t"))
                    count++;
                }
              
                Console.WriteLine(line);
            }
            Console.WriteLine( "There are " + count + " words that end in t or e");
            Console.ReadLine();
            myfile.Close();

            return count;
        }
    }


}
