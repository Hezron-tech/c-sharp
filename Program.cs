﻿// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("     ##");
            // Console.WriteLine("    #  #");
            // Console.WriteLine("   #    #");
            // Console.WriteLine(" #  #  #   #");

            //DATATYPES

            // string phrase="Hezron academy";
            // char grade='A';
            // int age =30;
            // double gpa = 3.2;
            // bool isMale = true;

            // Console.WriteLine("Hezron\n Academy");
            // Console.WriteLine(phrase);
            // Console.WriteLine(phrase[5]);
            //  Console.WriteLine(phrase.ToUpper());

            Console.Write("Enter your name:");
           
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Hello  " +name  +   "your age is" + age);
            Console.ReadLine();
           
        }
    }
}