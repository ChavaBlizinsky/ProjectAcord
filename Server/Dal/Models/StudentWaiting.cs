using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class StudentWaiting
{
    public int StudentWaitingCode { get; set; }

    public int StudentCode { get; set; }

    public int? CourseCode { get; set; }

    public DateOnly? WaitingDate { get; set; }

    public int? WaitingReasonCode { get; set; }

    public string? WaitingReason { get; set; }

    public virtual Course? CourseCodeNavigation { get; set; }

    public virtual Student StudentCodeNavigation { get; set; } = null!;

    public virtual Reason? WaitingReasonCodeNavigation { get; set; }
}
