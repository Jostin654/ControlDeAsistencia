using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControlDeAsistenciaUniversidad.Universidad;

namespace ControlDeAsistenciaUniversidad
{
    public static class Extensionestudiante
    {
        public static void MostrarInformacion(this Universidad.Estudiante estudiante)
        {
            double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.TotalSesiones);
            String estado = Universidad.Estudiante.Asistencia.CumpleAsistencia(porcentaje);

            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Asistencia: {porcentaje:F2}%");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine();
        }

        public static void MostrarReporteAprobados(this List<Universidad.Estudiante> estudiantes)
        {
            Console.WriteLine("\n--- Reporte de Aprobados ---");
            foreach (var estudiante in estudiantes)
            {
                double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.TotalSesiones);
                string estado = Universidad.Estudiante.Asistencia.CumpleAsistencia(porcentaje);

                if (estado == "Aprobado")
                {
                    Console.WriteLine($"{estudiante.Nombre} ha aprobado con {porcentaje:F2}% de asistencia.");
                }
            }
        }

        public static void MostrarReporteNoAprobados(this List<Universidad.Estudiante> estudiantes)
        {
            Console.WriteLine("\n--- Reporte de No Aprobados ---");
            foreach (var estudiante in estudiantes)
            {
                double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.TotalSesiones);
                string estado = Universidad.Estudiante.Asistencia.CumpleAsistencia(porcentaje);

                if (estado == "Reprobado")
                {
                    Console.WriteLine($"{estudiante.Nombre} no ha aprobado con {porcentaje:F2}% de asistencia.");
                }
            }
        }
    }
}
