using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Student
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

    public virtual ICollection<AnnualHoursSystem> AnnualHoursSystems { get; set; } = new List<AnnualHoursSystem>();

    public virtual Family CodeFamilyNavigation { get; set; } = null!;

    public virtual ICollection<EndStudent> EndStudents { get; set; } = new List<EndStudent>();

    public virtual ICollection<StudentWaiting> StudentWaitings { get; set; } = new List<StudentWaiting>();

    public virtual ICollection<StudentsOfCourse> StudentsOfCourses { get; set; } = new List<StudentsOfCourse>();
}
