using System;
using System.IO;

namespace horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your horoscope sign:");
            string usersign = Console.ReadLine();
            Console.WriteLine(gethoroscope(usersign));


        }

        public static string[] readhoroscope()
        {
            string filepath = @"C:\Users\opilane\samples\horoscope.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            Console.WriteLine(datafromfile.Length);
            return datafromfile;
        }
        public static string gethoroscope(string userinput)
        {
            string[] horoscope = readhoroscope();
            string todayhoroscope = "";

            foreach(string element in horoscope)
            {
                if(element.Contains(userinput))
                {
                    todayhoroscope = element;
                }
            }
            return todayhoroscope;
        }
        



    }
}
