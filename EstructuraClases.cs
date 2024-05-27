public class MiembroDeLaComunidad
{
}

public class Empleado : MiembroDeLaComunidad
{
}

public class Estudiante : MiembroDeLaComunidad
{
}

public class ExAlumno : MiembroDeLaComunidad
{
}

public class Docente : Empleado
{
}

public class Administrativo : Empleado
{
}

public class Administrador : Docente
{
}

public class Maestro : Docente
{
}

public class Programa
{
    public static void Main(string[] args)
    {

        MiembroDeLaComunidad miembro = new MiembroDeLaComunidad();
        Empleado empleado = new Empleado();
        Estudiante estudiante = new Estudiante();
        ExAlumno exAlumno = new ExAlumno();
        Docente docente = new Docente();
        Administrativo administrativo = new Administrativo();
        Administrador administrador = new Administrador();
        Maestro maestro = new Maestro();

    }
}
