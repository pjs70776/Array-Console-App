using System;
using System.Collections.Generic;

namespace Array_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////begin program
            Console.WriteLine("Welcome to the Array App");
            Console.ReadLine();

            ////array of strings and user input
            Console.WriteLine("Select an index from 0 to 3 and a corresponding car will appear.");

            List<string> MyCar = new List<string>();
            MyCar.Add("Tesla");
            MyCar.Add("Rivian");
            MyCar.Add("Lucid");
            MyCar.Add("Ford");

            int index = int.Parse(Console.ReadLine());
            

            //if else statement 
            if (index == 0 || index == 1 || index == 2 || index == 3)

            {
                Console.WriteLine("You chose: " + MyCar[index]);
            }

            else

            {
                Console.WriteLine("Error. Only enter numbers 0 - 3");
            }
            
            Console.ReadLine();




            //array of integers and user input
            double[] MyIntegers = new double[] { 77, 140598, 3345, 2341654, 89564 };
            Console.WriteLine("Please select the index of the array");

            int index1 = int.Parse(Console.ReadLine());

            //if else statement
            if (index1 == 0 || index1 == 1 || index1 == 2 || index1 == 3 || index1 == 4) 

            {
                Console.WriteLine("You chose: " + MyIntegers[index1]);
            }

            else 
            
            {
                Console.WriteLine("Error. Only enter numbers 0 - 4");
            }

            Console.ReadLine();




            //List of strings and user input
            Console.WriteLine("Select an index of 0 to 3 and a phrase will appear.");
            
            List<string> Phrase = new List<string>();
            Phrase.Add("Hahaha. What a story, Mark!");
            Phrase.Add("Oh hi, Mark.");
            Phrase.Add("You are tearing me apart, Lisa!");
            Phrase.Add("Leave your stupid comments in your pocket!");

            int index2 = int.Parse(Console.ReadLine());
            

            //if else statement
            if (index2 == 0 || index2 == 1 || index2 == 2 || index2 == 3) 

            {
                Console.WriteLine("You chose: " + Phrase[index2]);
            }

            else 

            {
               Console.WriteLine("Error. Only enter numbers 0 - 3");
            }
            Console.ReadLine();

            


        }
    }
}
