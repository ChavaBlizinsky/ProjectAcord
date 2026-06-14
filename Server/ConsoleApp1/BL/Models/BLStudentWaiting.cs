using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLStudentWaiting
{
    public int StudentWaitingCode { get; set; }

    public int StudentCode { get; set; }

    public int? CourseCode { get; set; }

    public DateOnly? WaitingDate { get; set; }

    public int? WaitingReasonCode { get; set; }

    public string? WaitingReason { get; set; }

    public virtual BLCourse? CourseCodeNavigation { get; set; }

    public virtual BLStudent StudentCodeNavigation { get; set; } = null!;

    public virtual BLReason? WaitingReasonCodeNavigation { get; set; }
}
