namespace C40_Interfaces_Demo;

internal class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane();
        plane.FlightSpeed = 600;
        Superman superman = new Superman();
        superman.FlightSpeed = 700;
        List<IFlyable> list = new List<IFlyable>();

        list.Add(plane);
        list.Add(superman);

        //foreach (IFlyable flyable in list)
        //{
        //    Console.WriteLine("Flight Speed: ");
        //    Console.WriteLine(flyable.FlightSpeed);
        //    flyable.Fly();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}

        IFlyable someItem;

        Console.WriteLine("Enter in something that flies: ");
        string userInput = Console.ReadLine();

        if (userInput == "superman")
        {
            someItem = new Superman();
            someItem.Fly();
        }
        else if (userInput == "plane")
        {
            someItem = new Plane();
            someItem.Fly();
        }
        else
        {
            Console.WriteLine($"{userInput} is flying!");
        }
    }
}
