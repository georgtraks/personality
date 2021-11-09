using System;
using System.IO;

namespace colors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("select one color: (red, blue, green, yellow");
            string usercolor = Console.ReadLine();
            Console.WriteLine(getcolors(usercolor));
        }

        public static string[] getpersonality()
        {
            string filepath = @"C:\Users\opilane\samples\personality.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            Console.WriteLine(datafromfile.Length);

            return datafromfile;
        }

        public static string getcolors(string userinput)
        {
            string[] personality = getpersonality();
            string personpersonality = "";
            foreach (string element in personality)
            {
                if(element.Contains(userinput))
                {
                    personpersonality = element;
                }
            }
            return personpersonality;
        }
    }
}
