using ContosoUniversity.Data.Entities;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Kevin", LastName="García", EnrollmentDate=DateTime.Parse("2009-09-09")},
                new Student{FirstMidName="Jhohana", LastName="García", EnrollmentDate=DateTime.Parse("2008-02-01")},
                new Student{FirstMidName="Roberto", LastName="Ortíz", EnrollmentDate=DateTime.Parse("2009-09-09")},
                new Student{FirstMidName="Vladimir", LastName="Hernández", EnrollmentDate=DateTime.Parse("2009-09-09")},
                new Student{FirstMidName="Donald", LastName="Martínez", EnrollmentDate=DateTime.Parse("2009-09-09")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=123, Title="Programación I", Credits=4},
                new Course{CourseID=956, Title="Programación II", Credits=3},
                new Course{CourseID=225, Title="Inglés Intermedio", Credits=4},
                new Course{CourseID=745, Title="Matemática I", Credits=3},
                new Course{CourseID=159, Title="Programación Estructurada", Credits=3}
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }

            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1, CourseID=123, Grade=Grade.A},
                new Enrollment{StudentID=2, CourseID=225, Grade=Grade.C},
                new Enrollment{StudentID=3, CourseID=956, Grade=Grade.B},
                new Enrollment{StudentID=4, CourseID=745, Grade=Grade.A},
                new Enrollment{StudentID=5, CourseID=159, Grade=Grade.A}
            };

            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
