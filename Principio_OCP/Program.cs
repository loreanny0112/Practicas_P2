using System;

public class Program
{
    public static void Main()
    {
        Student student = new Student { Name = "Juan Pérez" };

        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Programación en C#" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Programación en Java" };
        Course hybridCourse = new HybridCourse { CourseId = 3, Title = "Desarrollo Full Stack" };

        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
    }
}
