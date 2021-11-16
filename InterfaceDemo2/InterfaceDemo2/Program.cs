using System;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            //object of chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //object of car
            Car damagedCar = new Car(80f, "Blue");


            //adding chairs as destructables nearby to car
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);


            damagedCar.Destroy();
        }
    }
}
