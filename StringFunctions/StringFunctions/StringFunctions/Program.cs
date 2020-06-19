using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jeremy";
            string quote = "The man said, \"Hello, " + name + ", is it me you're looking for?\" \n \t Hello on a new line and tabbed in";
            string fileName = @"C\Users\Jeremy";

            string concat = name + quote + fileName;
            name = name.ToUpper();

            string sentence1 = "\nThe little blue bird lived in a shoe. ";
            string sentence2 = "It wasn't a very big shoe and the little blue bird was getting serious with a female blue bird. ";
            string sentence3 = "The little blue bird applied for a home loan and now lives in a 3 bedroom, 2 bird feeder house with 6 chics and a mortgage. ";
            string sentence4 = "Sometimes, on his way home from work at the worm factory, the little blue bird flies by that old shoe and sighs.";

            StringBuilder sb = new StringBuilder();
            sb.Append(sentence1 + sentence2 + sentence3 + sentence4);

            Console.WriteLine(concat);
            Console.WriteLine(name);
            Console.WriteLine(sb);
            Console.ReadLine();

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");

            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}
