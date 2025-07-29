using SchoolDAL.Models;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBLL
{
    public class TeacherBL
    {
        public List<Teacher> getTeacher()
        {
            List<Teacher> teacher;
            //out List<Student> students;
            TeacherData.readFile(out teacher);
            return teacher;
        }
    }
}
