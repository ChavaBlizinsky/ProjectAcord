using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Course
{
    public int CodeOfCourse { get; set; }

    public string NameOfCourse { get; set; } = null!;

    public string SexOfCourse { get; set; } = null!;

    public double PriceOfCourse { get; set; }

    public string? DescriptionOfCourse { get; set; }

    public int? DuretionTimeOfCourse { get; set; }

    public int? FromAge { get; set; }

    public int? ToAge { get; set; }

    public virtual ICollection<EndStudent> EndStudents { get; set; } = new List<EndStudent>();

    public virtual ICollection<EndTeacher> EndTeachers { get; set; } = new List<EndTeacher>();

    public virtual ICollection<StudentWaiting> StudentWaitings { get; set; } = new List<StudentWaiting>();

    public virtual ICollection<StudentsOfCourse> StudentsOfCourses { get; set; } = new List<StudentsOfCourse>();

    public virtual ICollection<TeachersOfCourse> TeachersOfCourses { get; set; } = new List<TeachersOfCourse>();
}
