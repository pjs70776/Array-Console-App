using System;
using System.Collections.Generic;

namespace Array_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////begin program
            //Console.WriteLine("Welcome to the Array App");
            //Console.ReadLine();

            ////array of strings and user input
            Console.WriteLine("Select an index from 0 to 3 and a corresponding car will appear.");
            Console.ReadLine();
            string[] MyCars = { "Chevy", "Ford", "Toyota", "Dodge" };
            int stringIndex1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyCars[0]);
            Console.WriteLine(MyCars[1]);
            Console.WriteLine(MyCars[2]);
            Console.WriteLine(MyCars[3]);
            Console.ReadLine();


            //////array of integers and user input
            Console.WriteLine("Select an index from 0 to 3 and a corresponding number in an array will appear.");
            Console.ReadLine();
            int[] MyIntegers = { 77, 140596, 3340, 2349304 };
            
            Console.WriteLine(MyIntegers[0]);
            Console.WriteLine(MyIntegers[1]);
            Console.WriteLine(MyIntegers[2]);
            Console.WriteLine(MyIntegers[3]);
            Console.ReadLine();
            

            ////List of strings and user input
            Console.WriteLine("Select an index of 0 to 3 and a phrase will appear.");
            Console.ReadLine();
            List<string> Phrase = new List<string>();
            Phrase.Add("Hahaha. What a story, Mark!");
            Phrase.Add("Oh hi, Mark.");
            Phrase.Add("You are tearing me apart, Lisa!");
            Phrase.Add("Leave your stupid comments in your pocket!");

            Console.WriteLine(Phrase[0]);
            Console.WriteLine(Phrase[1]);
            Console.WriteLine(Phrase[2]);
            Console.WriteLine(Phrase[3]);

            int stringIndex2 = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();


        }
    }
}
