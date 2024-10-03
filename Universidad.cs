using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAsistenciaUniversidad
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int TotalSesiones { get; set; }
            public int SesionesAsistidas { get; set; }

            public Estudiante(string nombre, int totalSesiones, int sesionesAsistidas)
            {
                Nombre = nombre;
                TotalSesiones = totalSesiones;
                SesionesAsistidas = sesionesAsistidas;
            }

            public class Asistencia
            {
                private int totalSesiones;
                private int sesionesAsistidas;

                public Asistencia(int totalSesiones, int sesionesAsistidas)
                {
                    this.totalSesiones = totalSesiones;
                    this.sesionesAsistidas = sesionesAsistidas;
                }

                public static double CalcularPorcentaje(int sesionesAsistidas, int totalSesiones)
                {
                    if (totalSesiones == 0 || totalSesiones < 1 )
                        return 0;
                    return (double)sesionesAsistidas / totalSesiones * 100;
                }

                public static string CumpleAsistencia(double porcentaje)
                {
                    String mensaje;
                    if (porcentaje < 75)                        
                    {
                        mensaje = "Reprobado";
                    }
                    else 
                    {
                        mensaje = "Aprobado";
                    }
                    return mensaje;
                }
            }
        }

    }
}
