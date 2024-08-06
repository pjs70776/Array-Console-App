using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //begin program
            Console.WriteLine("Welcome to the Array App");
            Console.ReadLine();
               
            //array of strings and user input
            Console.WriteLine("Select an index from 0 to 3 and a corresponding car will appear.");
            Console.ReadLine();
            string[] MyCars = { "Chevy", "Ford", "Toyota", "Dodge" };
            
            Console.ReadLine();


            //array of integers and user input
            Console.WriteLine("Select an index from 0 to 3 and a corresponding number in an array will appear.");
            Console.ReadLine();
            int[] MyIntegers = { 77, 140596, 3340, 2349304 };
            
            Console.ReadLine();


            //List of strings and user input
            Console.WriteLine("Select an index of 0 to 3 and a phrase will appear.");
            Console.ReadLine();
            string phrase1 = "Hahaha. What a story, Mark!";
            string phrase2 = "Oh hi, Mark.";
            string phrase3 = "You are tearing me apart, Lisa!";
            string phrase4 = "Leave your stupid comments in your pocket!";
            
            Console.ReadLine();


        }
    }
}
