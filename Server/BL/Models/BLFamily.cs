using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public  class BLFamily
{
    public int CodeFamily { get; set; }

    public string LastName { get; set; } = null!;

    public string? Address { get; set; }

    public string Phone { get; set; } = null!;

    public string? Mail { get; set; }

    public string? Paiy { get; set; }

    //public virtual ICollection<BLStudent> Students { get; set; } = new List<BLStudent>();
}
