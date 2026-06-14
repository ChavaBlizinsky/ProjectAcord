using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLStudent
{
    public int CodeOfStudent { get; set; }

    public int IdOfStudents { get; set; }

    public int CodeFamily { get; set; }

    public string FirstName { get; set; } = null!;

    public DateOnly? BirsDate { get; set; }

    public DateOnly? BeginDate { get; set; }

    public int? CountLessonAct { get; set; }

    public int? FixLesson { get; set; }

    public string? ActOrWaitOrFinish { get; set; }

    public DateOnly? FinishDate { get; set; }

    public string? Coments { get; set; }

    public string? KCh { get; set; }

    public string? sexOfStudent { get; set; }

    //public virtual ICollection<BLAnnualHoursSystem> AnnualHoursSystems { get; set; } = new List<BLAnnualHoursSystem>();

    //public virtual BLFamily CodeFamilyNavigation { get; set; } = null!;

    //public virtual ICollection<BLEndStudent> EndStudents { get; set; } = new List<BLEndStudent>();

    //public virtual ICollection<BLStudentWaiting> StudentWaitings { get; set; } = new List<BLStudentWaiting>();

    //public virtual ICollection<BLStudentsOfCourse> StudentsOfCourses { get; set; } = new List<BLStudentsOfCourse>();
}
