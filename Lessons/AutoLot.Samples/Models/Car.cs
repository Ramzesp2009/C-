using System;
using System.Collections.Generic;
using System.Text;

namespace AutoLot.Samples.Models;

public class Car
{
    public string? Color { get; set; }
    public string? PetName { get; set; }
    public int MakeId { get; set; }
    public Make MakeNavigation { get; set; }
    public Radio RadioNavigation { get; set; }
    public IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();
}
