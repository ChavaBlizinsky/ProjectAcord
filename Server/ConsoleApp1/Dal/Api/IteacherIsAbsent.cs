using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    public interface IteacherIsAbsent : ICrud<TeacherIsAbsent>
    {
        void Create(TeacherIsAbsent teacherIsAbsent);
    }
}
