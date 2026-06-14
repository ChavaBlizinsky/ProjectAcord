using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLCourse
{
    public int CodeOfCourse { get; set; }

    public string NameOfCourse { get; set; } = null!;

    public string SexOfCourse { get; set; } = null!;

    public double PriceOfCourse { get; set; }

    public string? DescriptionOfCourse { get; set; }

    public int? DuretionTimeOfCourse { get; set; }

    public int? FromAge { get; set; }

    public int? ToAge { get; set; }

    //public virtual ICollection<BLEndStudent> EndStudents { get; set; } = new List<BLEndStudent>();

    //public virtual ICollection<BLEndTeacher> EndTeachers { get; set; } = new List<BLEndTeacher>();

    //public virtual ICollection<BLStudentWaiting> StudentWaitings { get; set; } = new List<BLStudentWaiting>();

    //public virtual ICollection<BLStudentsOfCourse> StudentsOfCourses { get; set; } = new List<BLStudentsOfCourse>();

    //public virtual ICollection<BLTeachersOfCourse> TeachersOfCourses { get; set; } = new List<BLTeachersOfCourse>();
}
