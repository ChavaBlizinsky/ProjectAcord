using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AnnualHoursSystem
{
    public int AnnualHoursSystemCode { get; set; }

    public int TeacherCode { get; set; }

    public int StudentCode { get; set; }

    public DateOnly? Date { get; set; }

    public string? DayInWeek { get; set; }

    public TimeOnly? Hour { get; set; }

    public string? Status { get; set; }

    public virtual Student StudentCodeNavigation { get; set; } = null!;

    public virtual Teacher TeacherCodeNavigation { get; set; } = null!;
}
