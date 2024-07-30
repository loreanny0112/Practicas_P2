using System;
        
namespace Principio_LSP
{

namespace CursoApp
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public Course(int courseId, string title)
        {
            CourseId = courseId;
            Title = title;
        }

        public abstract void Subscribe(Student std);
        public abstract string GetCourseDetails();
    }

    public class OnlineCourse : Course
    {
        public OnlineCourse(int courseId, string title) : base(courseId, title)
        {
        }

        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso en línea
            Console.WriteLine($"{std.Name} se ha suscrito al curso en línea: {Title}");
        }

        public override string GetCourseDetails()
        {
            return $"Curso en línea: {Title} (ID: {CourseId})";
        }
    }

    public class OfflineCourse : Course
    {
        public OfflineCourse(int courseId, string title) : base(courseId, title)
        {
        }

        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso presencial
            Console.WriteLine($"{std.Name} se ha suscrito al curso presencial: {Title}");
        }

        public override string GetCourseDetails()
        {
            return $"Curso presencial: {Title} (ID: {CourseId})";
        }
    }

    public class HybridCourse : Course
    {
        private OnlineCourse onlineCourse;
        private OfflineCourse offlineCourse;

        public HybridCourse(int courseId, string title) : base(courseId, title)
        {
            onlineCourse = new OnlineCourse(courseId, title + " (Parte en línea)");
            offlineCourse = new OfflineCourse(courseId, title + " (Parte presencial)");
        }

        public override void Subscribe(Student std)
        {
            // Suscribir al estudiante tanto al curso en línea como al presencial
            onlineCourse.Subscribe(std);
            offlineCourse.Subscribe(std);
            Console.WriteLine($"{std.Name} se ha suscrito al curso híbrido: {Title}");
        }

        public override string GetCourseDetails()
        {
            return $"Curso híbrido: {Title} (ID: {CourseId})\n" +
                   $"Detalles del curso en línea: {onlineCourse.Title}\n" +
                   $"Detalles del curso presencial: {offlineCourse.Title}";
        }
    }
}


}