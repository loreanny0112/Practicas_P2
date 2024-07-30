using System;
using Principio_LSP;
using Principio_LSP.CursoApp;

namespace Principio_LSP
{
    public class Program
    {        public static void Main()
        {
            Student student = new Student { Name = "Juan Pérez" };

            Course onlineCourse = new OnlineCourse(1, "Programación en C#");
            Course offlineCourse = new OfflineCourse(2, "Programación en Java");
            Course hybridCourse = new HybridCourse(3, "Desarrollo Full Stack");

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);
            hybridCourse.Subscribe(student);

            Console.WriteLine(onlineCourse.GetCourseDetails());
            Console.WriteLine(offlineCourse.GetCourseDetails());
            Console.WriteLine(hybridCourse.GetCourseDetails());
        }
    }

}
