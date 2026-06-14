using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class DbManager : DbContext
{
    public DbManager()
    {
    }

    public DbManager(DbContextOptions<DbManager> options)
        : base(options)
    {
    }

    public virtual DbSet<AnnualHoursSystem> AnnualHoursSystems { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<EndStudent> EndStudents { get; set; }

    public virtual DbSet<EndTeacher> EndTeachers { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Reason> Reasons { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentIsAbsent> StudentIsAbsents { get; set; }

    public virtual DbSet<StudentWaiting> StudentWaitings { get; set; }

    public virtual DbSet<StudentsOfCourse> StudentsOfCourses { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherIsAbsent> TeacherIsAbsents { get; set; }

    public virtual DbSet<TeachersOfCourse> TeachersOfCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='A:\\c#\\ProjectEnd\\ConsoleApp1\\ConsoleApp1\\dataBase\\dataBase.mdf';Integrated Security=True;Connect Timeout=30;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnnualHoursSystem>(entity =>
        {
            entity.HasKey(e => e.AnnualHoursSystemCode).HasName("PK__AnnualHo__D6E011140163A436");

            entity.ToTable("AnnualHoursSystem");

            entity.Property(e => e.AnnualHoursSystemCode)
                .ValueGeneratedNever()
                .HasColumnName("annualHoursSystemCode");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DayInWeek)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("dayInWeek");
            entity.Property(e => e.Hour).HasColumnName("hour");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.StudentCode).HasColumnName("studentCode");
            entity.Property(e => e.TeacherCode).HasColumnName("teacherCode");

            entity.HasOne(d => d.StudentCodeNavigation).WithMany(p => p.AnnualHoursSystems)
                .HasForeignKey(d => d.StudentCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnualHoursSystem_ToTable_1");

            entity.HasOne(d => d.TeacherCodeNavigation).WithMany(p => p.AnnualHoursSystems)
                .HasForeignKey(d => d.TeacherCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnualHoursSystem_ToTable");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CodeOfCourse).HasName("PK__tmp_ms_x__E46A8273BA9AE414");

            entity.Property(e => e.CodeOfCourse).HasColumnName("codeOfCourse");
            entity.Property(e => e.DescriptionOfCourse)
                .IsUnicode(false)
                .HasDefaultValue("???? ????? ?????? ??????")
                .HasColumnName("descriptionOfCourse");
            entity.Property(e => e.DuretionTimeOfCourse)
                .HasDefaultValue(30)
                .HasColumnName("duretionTimeOfCourse");
            entity.Property(e => e.FromAge).HasColumnName("fromAge");
            entity.Property(e => e.NameOfCourse)
                .HasMaxLength(20)
                .HasColumnName("nameOfCourse");
            entity.Property(e => e.PriceOfCourse).HasColumnName("priceOfCourse");
            entity.Property(e => e.SexOfCourse)
                .HasMaxLength(10)
                .HasColumnName("sexOfCourse");
            entity.Property(e => e.ToAge).HasColumnName("toAge");
        });

        modelBuilder.Entity<EndStudent>(entity =>
        {
            entity.HasKey(e => e.CodeEndStudent).HasName("PK__EndStude__D635CF17F9B84616");

            entity.ToTable("EndStudent");

            entity.Property(e => e.CodeEndStudent)
                .ValueGeneratedNever()
                .HasColumnName("codeEndStudent");
            entity.Property(e => e.CodeCours).HasColumnName("codeCours");
            entity.Property(e => e.CodeReasonEndS).HasColumnName("codeReasonEndS");
            entity.Property(e => e.CodeSudent).HasColumnName("codeSudent");
            entity.Property(e => e.ReasonEndS)
                .HasMaxLength(70)
                .IsFixedLength()
                .HasColumnName("reasonEndS");

            entity.HasOne(d => d.CodeCoursNavigation).WithMany(p => p.EndStudents)
                .HasForeignKey(d => d.CodeCours)
                .HasConstraintName("FK_EndStudent_ToTable_1");

            entity.HasOne(d => d.CodeReasonEndSNavigation).WithMany(p => p.EndStudents)
                .HasForeignKey(d => d.CodeReasonEndS)
                .HasConstraintName("FK_EndStudent_ToTable_2");

            entity.HasOne(d => d.CodeSudentNavigation).WithMany(p => p.EndStudents)
                .HasForeignKey(d => d.CodeSudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EndStudent_ToTable");
        });

        modelBuilder.Entity<EndTeacher>(entity =>
        {
            entity.HasKey(e => e.CodeEndTeacher).HasName("PK__EndTeach__0F71F7EFD4C75205");

            entity.ToTable("EndTeacher");

            entity.Property(e => e.CodeEndTeacher)
                .ValueGeneratedNever()
                .HasColumnName("codeEndTeacher");
            entity.Property(e => e.CodeOfCourse).HasColumnName("codeOfCourse");
            entity.Property(e => e.CodeOfTeacher).HasColumnName("codeOfTeacher");
            entity.Property(e => e.CodeReasonEndT).HasColumnName("codeReasonEndT");
            entity.Property(e => e.ReasonEnd)
                .HasMaxLength(70)
                .IsFixedLength()
                .HasColumnName("reasonEnd");

            entity.HasOne(d => d.CodeOfCourseNavigation).WithMany(p => p.EndTeachers)
                .HasForeignKey(d => d.CodeOfCourse)
                .HasConstraintName("FK_EndTeacher_ToTable_1");

            entity.HasOne(d => d.CodeOfTeacherNavigation).WithMany(p => p.EndTeachers)
                .HasForeignKey(d => d.CodeOfTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EndTeacher_ToTable");

            entity.HasOne(d => d.CodeReasonEndTNavigation).WithMany(p => p.EndTeachers)
                .HasForeignKey(d => d.CodeReasonEndT)
                .HasConstraintName("FK_EndTeacher_ToTable_2");
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.CodeFamily).HasName("PK__tmp_ms_x__85C94195A4568F42");

            entity.ToTable("Family");

            entity.Property(e => e.CodeFamily).HasColumnName("codeFamily");
            entity.Property(e => e.Address)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("address");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("lastName");
            entity.Property(e => e.Mail)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("mail");
            entity.Property(e => e.Paiy)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("paiy");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Reason>(entity =>
        {
            entity.HasKey(e => e.CodeReason).HasName("PK__Reason__26E58983BBFF2195");

            entity.ToTable("Reason");

            entity.Property(e => e.CodeReason).HasColumnName("codeReason");
            entity.Property(e => e.DiscribeReason)
                .HasMaxLength(70)
                .IsFixedLength()
                .HasColumnName("discribeReason");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.CodeOfStudent).HasName("PK__tmp_ms_x__8B071A592282E974");

            entity.Property(e => e.CodeOfStudent).HasColumnName("codeOfStudent");
            entity.Property(e => e.ActOrWaitOrFinish)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("actOrWaitOrFinish");
            entity.Property(e => e.BeginDate).HasColumnName("beginDate");
            entity.Property(e => e.BirsDate).HasColumnName("birsDate");
            entity.Property(e => e.CodeFamily).HasColumnName("codeFamily");
            entity.Property(e => e.Coments)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("coments");
            entity.Property(e => e.CountLessonAct).HasColumnName("countLessonAct");
            entity.Property(e => e.FinishDate).HasColumnName("finishDate");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("firstName");
            entity.Property(e => e.FixLesson)
                .HasDefaultValue(0)
                .HasColumnName("fixLesson");
            entity.Property(e => e.IdOfStudents).HasColumnName("idOfStudents");
            entity.Property(e => e.KCh)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("k.ch");

            entity.HasOne(d => d.CodeFamilyNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.CodeFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_ToTable");
        });

        modelBuilder.Entity<StudentIsAbsent>(entity =>
        {
            entity.HasKey(e => e.StudentIsAbsentCode).HasName("PK__StudentI__9AE3C40A2974C544");

            entity.ToTable("StudentIsAbsent");

            entity.Property(e => e.StudentIsAbsentCode).ValueGeneratedNever();
            entity.Property(e => e.CodeReasonAbsentS).HasColumnName("codeReasonAbsentS");
            entity.Property(e => e.FromDate).HasColumnName("fromDate");
            entity.Property(e => e.ReasonAbsentS)
                .HasMaxLength(70)
                .IsFixedLength()
                .HasColumnName("reasonAbsentS");
            entity.Property(e => e.StudentCode).HasColumnName("studentCode");
            entity.Property(e => e.ToDate).HasColumnName("toDate");
        });

        modelBuilder.Entity<StudentWaiting>(entity =>
        {
            entity.HasKey(e => e.StudentWaitingCode).HasName("PK__studentW__FE89E623B314134F");

            entity.ToTable("studentWaiting");

            entity.Property(e => e.StudentWaitingCode)
                .ValueGeneratedNever()
                .HasColumnName("studentWaitingCode");
            entity.Property(e => e.CourseCode).HasColumnName("courseCode");
            entity.Property(e => e.StudentCode).HasColumnName("studentCode");
            entity.Property(e => e.WaitingDate).HasColumnName("waitingDate");
            entity.Property(e => e.WaitingReason)
                .HasMaxLength(70)
                .IsFixedLength()
                .HasColumnName("waitingReason");
            entity.Property(e => e.WaitingReasonCode).HasColumnName("waitingReasonCode");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.StudentWaitings)
                .HasForeignKey(d => d.CourseCode)
                .HasConstraintName("FK_studentWaiting_ToTable_3");

            entity.HasOne(d => d.StudentCodeNavigation).WithMany(p => p.StudentWaitings)
                .HasForeignKey(d => d.StudentCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_studentWaiting_ToTable");

            entity.HasOne(d => d.WaitingReasonCodeNavigation).WithMany(p => p.StudentWaitings)
                .HasForeignKey(d => d.WaitingReasonCode)
                .HasConstraintName("FK_studentWaiting_ToTable_2");
        });

        modelBuilder.Entity<StudentsOfCourse>(entity =>
        {
            entity.HasKey(e => e.CodeSc).HasName("PK__Students__47F9709CE3EC5262");

            entity.Property(e => e.CodeSc).HasColumnName("codeSC");
            entity.Property(e => e.CodeOfCourseSc).HasColumnName("codeOfCourseSC");
            entity.Property(e => e.CodeOfStudentSc).HasColumnName("codeOfStudentSC");
            entity.Property(e => e.CodeOfTeacherSc).HasColumnName("codeOfTeacherSC");

            entity.HasOne(d => d.CodeOfCourseScNavigation).WithMany(p => p.StudentsOfCourses)
                .HasForeignKey(d => d.CodeOfCourseSc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentsOfCourses_ToTable_2");

            entity.HasOne(d => d.CodeOfStudentScNavigation).WithMany(p => p.StudentsOfCourses)
                .HasForeignKey(d => d.CodeOfStudentSc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentsOfCourses_ToTable_1");

            entity.HasOne(d => d.CodeOfTeacherScNavigation).WithMany(p => p.StudentsOfCourses)
                .HasForeignKey(d => d.CodeOfTeacherSc)
                .HasConstraintName("FK_StudentsOfCourses_ToTable");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.CodeOfTeacher).HasName("PK__tmp_ms_x__DA35BB01651E7505");

            entity.Property(e => e.CodeOfTeacher).HasColumnName("codeOfTeacher");
            entity.Property(e => e.ActOrNot)
                .HasMaxLength(20)
                .HasDefaultValue("true")
                .IsFixedLength()
                .HasColumnName("actOrNot");
            entity.Property(e => e.ComentTeacher)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("comentTeacher");
            entity.Property(e => e.FirstNameOfTeacher)
                .HasMaxLength(20)
                .HasColumnName("firstNameOfTeacher");
            entity.Property(e => e.IdOfTeacher)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("idOfTeacher");
            entity.Property(e => e.LastNameOfTeacher)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("lastNameOfTeacher");
            entity.Property(e => e.Mail)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("mail");
            entity.Property(e => e.PhoneOfTeacher)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phoneOfTeacher");
            entity.Property(e => e.SexOfTeacher)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sexOfTeacher");
        });

        modelBuilder.Entity<TeacherIsAbsent>(entity =>
        {
            entity.HasKey(e => e.TeacherIsAbsentCode).HasName("PK__teacherI__20A151C31ABBE60F");

            entity.ToTable("teacherIsAbsent");

            entity.Property(e => e.TeacherIsAbsentCode)
                .ValueGeneratedNever()
                .HasColumnName("teacherIsAbsentCode");
            entity.Property(e => e.CodeOfTeacher).HasColumnName("codeOfTeacher");
            entity.Property(e => e.CodeReasonAbsentT).HasColumnName("codeReasonAbsentT");
            entity.Property(e => e.FromDate).HasColumnName("fromDate");
            entity.Property(e => e.ReasonAbsentT)
                .HasMaxLength(70)
                .IsFixedLength()
                .HasColumnName("reasonAbsentT");
            entity.Property(e => e.ToDate).HasColumnName("toDate");

            entity.HasOne(d => d.CodeOfTeacherNavigation).WithMany(p => p.TeacherIsAbsents)
                .HasForeignKey(d => d.CodeOfTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_teacherIsAbsent_ToTable");

            entity.HasOne(d => d.CodeReasonAbsentTNavigation).WithMany(p => p.TeacherIsAbsents)
                .HasForeignKey(d => d.CodeReasonAbsentT)
                .HasConstraintName("FK_teacherIsAbsent_ToTable_1");
        });

        modelBuilder.Entity<TeachersOfCourse>(entity =>
        {
            entity.HasKey(e => e.CodeTc).HasName("PK__Teachers__47F9697FBD919BE8");

            entity.Property(e => e.CodeTc).HasColumnName("codeTC");
            entity.Property(e => e.CodeOfCourseTc).HasColumnName("codeOfCourseTC");
            entity.Property(e => e.CodeOfTeacherTc).HasColumnName("codeOfTeacherTC");

            entity.HasOne(d => d.CodeOfCourseTcNavigation).WithMany(p => p.TeachersOfCourses)
                .HasForeignKey(d => d.CodeOfCourseTc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersOfCourses_ToTable_1");

            entity.HasOne(d => d.CodeOfTeacherTcNavigation).WithMany(p => p.TeachersOfCourses)
                .HasForeignKey(d => d.CodeOfTeacherTc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersOfCourses_ToTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
