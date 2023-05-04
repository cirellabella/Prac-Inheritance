namespace Prac_Inheritance
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Purple");
            Air air = new Air("Yellow");
            Helicopter helicopter = new Helicopter("Pink", 5);
            Plane plane = new Plane("Chartreuse", 4);
            Sea sea = new Sea("Orange", "Sailboat");
            Land land = new Land("Amethyst", 3);

            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}