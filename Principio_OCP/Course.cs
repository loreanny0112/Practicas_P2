using System;

namespace Principio_OCP
{

public abstract class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    public abstract void Subscribe(Student std);
}

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso en línea
        Console.WriteLine($"{std.Name} se ha suscrito al curso en línea: {Title}");
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso presencial
        Console.WriteLine($"{std.Name} se ha suscrito al curso presencial: {Title}");
    }
}

// Nueva clase HybridCourse
public class HybridCourse : Course
{
    private OnlineCourse onlineCourse = new OnlineCourse();
    private OfflineCourse offlineCourse = new OfflineCourse();

    public override void Subscribe(Student std)
    {
        // Suscribir al estudiante tanto al curso en línea como al presencial
        onlineCourse.Title = this.Title + " (Parte en línea)";
        offlineCourse.Title = this.Title + " (Parte presencial)";
        onlineCourse.Subscribe(std);
        offlineCourse.Subscribe(std);
        Console.WriteLine($"{std.Name} se ha suscrito al curso híbrido: {Title}");
    }
}

}