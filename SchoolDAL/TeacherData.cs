using SchoolDAL.Context;
using SchoolDAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDAL
{
    public class TeacherData
    {
        public static void readFile( out List<Teacher> teacherList)
        {
            using (var context = new SchoolContext())
            {
                //var homeroomList = context.HomeroomTeacherOfClasses.ToList();

                //foreach (var item in homeroomList)
                //{
                //    Console.WriteLine($"Teacher ID: {item.IdTeacher}, Class: {item.Class}");
                //}
                

                teacherList = context.Teachers.ToList();
                foreach (var item in teacherList)
                {
                    Console.WriteLine($"Teacher ID: {item.Id}, Name: {item.FirstName} {item.LastName}, Phone: {item.Phone}, Email: {item.MailAddress}");
                }

                //var subjectList = context.Subjects.ToList();
                //foreach (var item in subjectList)
                //{
                //    Console.WriteLine($"Subject ID: {item.Id}, Subject Name: {item.SubjectName}");
                //}

                //studentList = context.Students.ToList();
                //foreach (var item in studentList)
                //{
                //    Console.WriteLine($"Student ID: {item.Id}, Name: {item.FirstName} {item.LastName}, Phone: {item.HomePhone}, Birthday Year: {item.BirthdayYear}, Class: {item.Class}, Address: {item.Address}");
                //}

                //var teacherOfSubjectInClassList = context.TeacherOfSubjectInClasses.ToList();
                //foreach (var item in teacherOfSubjectInClassList)
                //{
                //    Console.WriteLine($"Teacher ID: {item.IdTeacher}, Subject ID: {item.IdSubject}, Class: {item.Class}");
                //}

                //Console.ReadLine();
            }

            
        }
    }
    
}
