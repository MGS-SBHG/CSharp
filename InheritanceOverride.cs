/*
method overriding on Inheritance to display the name of the city.

classes as “CityBaseClass” and “CityDerivedClass”

Allow the derived class to override a method of the base class 
using virtual methods or Abstract methods.

Create the instance of the “CityDerivedClass” class in the main class, 
access the methods  

print the values
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOverride
{
    abstract class CityBaseClass
    {
        public abstract string DisplayCityName();
    }

    class CityDerivedClass : CityBaseClass
    {
        int cityNbr;
        public CityDerivedClass(int n) { cityNbr = n; }

        public override string DisplayCityName()
        {
            switch (cityNbr)
            {
                case 1:
                    return "Pensacola";
                    break;
                case 2:
                    return "Orlando";
                    break;
                case 3:
                    return "Atlanta";
                    break;
                case 4:
                    return "Raleigh";
                    break;
                default:
                    return ("Redmond");
                    break;
            } // switch
        } // DisplayCityName 
        }
        }
   
   class InheritanceOverride
    {
        static void Main(string[] args)
        {
                string city = new CityDerivedClass(2);
                Console.WriteLine($"City Name = {0}", city);
        }
    }
