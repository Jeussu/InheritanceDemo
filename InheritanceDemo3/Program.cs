namespace InheritanceDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chair to the IDestroyable list of the car
            // so that when we destroy the car the destroyable object
            // that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destory the car
            damagedCar.Destroy();
        }
    }
}