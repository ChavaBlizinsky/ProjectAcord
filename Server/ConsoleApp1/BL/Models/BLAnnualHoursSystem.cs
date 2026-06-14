using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLAnnualHoursSystem
{
    public int AnnualHoursSystemCode { get; set; }

    public int TeacherCode { get; set; }

    public int StudentCode { get; set; }

    public DateOnly? Date { get; set; }

    public string? DayInWeek { get; set; }

    public TimeOnly? Hour { get; set; }

    public string? Status { get; set; }

    //public virtual BLStudent StudentCodeNavigation { get; set; } = null!;

    //public virtual BLTeacher TeacherCodeNavigation { get; set; } = null!;
}
