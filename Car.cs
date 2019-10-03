using System;

// scope - the enclosing context or region that define where a variable can be used
// declaration space - namespace; class; methods
// specificity
//      variable declared class level is "less specific" than method level

namespace Section6
{
    // namespace variables - access to entire namespace

    class Car
    {
        //private variables define properties of car (i.e.class)
        // class variables - scope inside the class
        // keep it safe, enclosed accessible to outside methods/classes that need them
        //      to prevent accidental setting where Not allowed
        string color;
        int numberOfDoors;
        int speed; // class level - used elsewhere other than accelerate() method
        bool isConvertable;

        //Constructor - factory for creating objects of the class
        // no data or return type
        // always name of the class
        // can have as many constructors as needed

        // default constructor
        // no incoming values
        // set values later
        public Car()
        {
        }

        // constructor - can Not create an object that has less variables
        public Car(string carColor, int doors, bool convertable)
        {
            // set values to Get / Set accessors
            // NOT to the private variables 
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }

        //Get and Set Accessors - Properties that define noun-like 
        //attributes of the class
        // validation; error-checking; data checking
        // control who has access to the data
        // program with an assurance
        // access type, data type, name
        public string Color
        {
            // access the value
            get
            {return color; }

            // set / validate the value
            // value keyword ; sets the value behind the scene
            set
            {color = value;}
        }

        // auto-implemented properties 
        // compiler sets it up
        public bool IsConvertable
        {
            get; set;
        }

        // with validation
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if(value <= 4)
                {
                    numberOfDoors = value;
                }
                else
                {
                   //give the user some kind of appropriate error
                }
            }
        }

        //Methods - Verb attributes that tell what a class can do
        // what a car can do
        public void Accelerate()
        {
            // variable - Only available in this scope of this method
            speed = 0;
            // compiler knows method's "speed" variable
            Console.WriteLine("I am accelerating to " + speed + " miles per hour");
        }

        public bool FamilyCar()
        {
            // access the Get method
            if(NumberOfDoors >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
