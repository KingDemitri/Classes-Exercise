using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        public Car()
        {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
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