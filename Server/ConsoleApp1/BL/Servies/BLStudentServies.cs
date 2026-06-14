using BL.Api;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Api;
using DAL.Models;
namespace BL.Servies
{
    public class BLStudentServies : IBLStudents
    {

      IStudents student;
        public BLStudentServies(IDal dal)

        { student = dal.students; }


        public BLStudent ConvertToBl(Student student)
        {
            BLStudent blStudent = new BLStudent()
            {
                CodeOfStudent = student.CodeOfStudent,
                IdOfStudents = student.IdOfStudents,
                CodeFamily = student.CodeFamily,
                FirstName = student.FirstName,
                BirsDate = student.BirsDate,
                BeginDate = student.BeginDate,
                CountLessonAct = student.CountLessonAct,
                FixLesson = student.FixLesson,
                ActOrWaitOrFinish = student.ActOrWaitOrFinish,
                FinishDate = student.FinishDate,
                Coments = student.Coments,
                KCh = student.KCh,
                sexOfStudent = student.sexOfStudent
            };
            return blStudent;
        }

        public Student ConvertToDal(BLStudent blStudent)
        {
            Student student = new Student()
            {

                CodeOfStudent = blStudent.CodeOfStudent,
                IdOfStudents = blStudent.IdOfStudents,
                CodeFamily = blStudent.CodeFamily,
                FirstName = blStudent.FirstName,
                BirsDate = blStudent.BirsDate,
                BeginDate = blStudent.BeginDate,
                CountLessonAct = blStudent.CountLessonAct,
                FixLesson = blStudent.FixLesson,
                ActOrWaitOrFinish = blStudent.ActOrWaitOrFinish,
                FinishDate = blStudent.FinishDate,
                Coments = blStudent.Coments,
                KCh = blStudent.KCh,
                sexOfStudent = blStudent.sexOfStudent
            };
            return student;
        }


        public void Create(BLStudent item)
        {
            student.Create(ConvertToDal(item));
        }

        public void Delete(BLStudent item)
        {
            throw new NotImplementedException();
        }

        public List<BLStudent> Read()
        {
            List<BLStudent> list = new List<BLStudent>();
            foreach (var item in student.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLStudent item)
        {
            throw new NotImplementedException();
        }
    }
}
