﻿using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
        
        Car Luxury = new Car();
            Luxury.Make = "Lamborghini";
            Luxury.Model = "Aventador (LP 700-4)";
            Luxury.Year = 2011;

            Console.WriteLine(Luxury.Make);
            Console.WriteLine(Luxury.Model);
            Console.WriteLine(Luxury.Year);
        }
    }
}



//Create a class named Car - make sure it is public
//In the Car class:
//    Create a Make property of type string that is public
//    Create a Model property of type string that is public
//    Create a Year property of type int that is public
//In the Main method:
//        Create a new instance of the Car class
//        Set values in the properties for the object
//        Print the values of each property to the Console