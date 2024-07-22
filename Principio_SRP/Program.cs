using NombreDelProyecto.Models;
using NombreDelProyecto.Services;

namespace Principio_SRP
{
    public class Program
    {
        public static void Main()
        {
            Persona persona = new Persona("Juan Pérez", 30, "Calle Falsa 123", "juan.perez@itla.edu.do");
            Impresora impresora = new Impresora();
            EmailService emailService = new EmailService("smtp.tuservidor.com", 587, "tuemail@itla.edu.do", "tucontraseña");

            impresora.ImprimirDatos(persona);
            emailService.EnviarCorreoElectronico(persona.CorreoElectronico, "Asunto de prueba", "Hola, este es un mensaje de prueba.");
        }
    }
}