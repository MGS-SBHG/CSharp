using Microsoft.VisualStudio.TestTools.UnitTesting;

// TestMethod 
//      arrange
//      act
//      assert

namespace Section6
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange 
            // create an instance with "new" keyword
            Car myCar = new Car("Red", 2, true);

            //act - to call a method

            //assert - test car color property
            StringAssert.Equals(myCar.Color, "Red");
        }

        [TestMethod]
        public void Call_Acceleration_Method()
        {
            //arrange
            Car myCar = new Car("Red", 2, true);

            //act
            myCar.Accelerate();
        }

        [TestMethod]
        public void Call_FamilyCar_Method()
        {
            //arrange
            Car myCar = new Car("Red", 4, true); // pass
            // Car myCar = new Car("Red", 2, true); // fail

            //act
            bool carType = myCar.FamilyCar();

            //assert
            if(carType == true)
            {
                Assert.IsTrue(carType == true);

            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
