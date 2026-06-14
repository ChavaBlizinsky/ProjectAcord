using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Family
{
    public int CodeFamily { get; set; }

    public string LastName { get; set; } = null!;

    public string? Address { get; set; }

    public string Phone { get; set; } = null!;

    public string? Mail { get; set; }

    public string? Paiy { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
