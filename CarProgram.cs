/*
Creates a Car class with 
in  Engine, Tyre, Sound System properties a base class. 

Program inherit all the functionality 
and gives custom color to a car using interface
*/

using System;
namespace Car
{
    class CarProgram
    {
        interface Icar
        {
            // members
            setCarColor(string color);
            getCarColor();
        }
    }
    // base class
    class Car : Icar {
    // fields
    private string engine;
    private string tyre;
    private string soundSystem;
    
    // Constructor 
    public Car(string engine, string tyre, string soundSystem)
    {
        engine = engine;
        tyre = tyre;
        soundSystem = soundSystem;
    }

    public string engine { get { return engine; } set { engine = value; } }
    public string tyre { get { return tyre; } set { tyre = value; } }
    public string soundSystem { get { return soundSystem; } set { soundSystem = value; } }
    }

    static void Main(string[] args)
    {
        Car carMB = new Car(“V8 DOHC Turbo”, “Pirellis”, “Blaupunkt” );
        carMB.carColor.set(“white”);
        Console.WriteLine("engine {0} tires are {1} sound system is {2} car color is {3}", carMB.engine.get(), carMB.tyre.get(), carMB.soundSystem.get(), carMB.carColor.get());
    }