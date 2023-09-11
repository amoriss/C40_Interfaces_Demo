using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C40_Interfaces_Demo;
internal class Superman : IFlyable, ISuperStrength
{
    public int FlightSpeed { get; set; }
    public int MaxWeightCanLift { get; set; }

    public void Fly()
    {
        Console.WriteLine("SUPERMAN is FLYING");
    }
}
