using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C40_Interfaces_Demo;
internal interface IFlyable
{
    public int FlightSpeed { get; set; }
    public void Fly();
}
