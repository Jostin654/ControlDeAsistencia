using ControlDeAsistenciaUniversidad;

List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>
            {
                new Universidad.Estudiante("Juan", 20, 18),
                new Universidad.Estudiante("María", 20, 14),
                new Universidad.Estudiante("Carlos", 20, 10),
                new Universidad.Estudiante("Ana", 30, 28),
                new Universidad.Estudiante("Pedro", 25, 20),
                new Universidad.Estudiante("Laura", 22, 16),
                new Universidad.Estudiante("Raúl", 18, 12),
                new Universidad.Estudiante("Luisa", 20, 15),
                new Universidad.Estudiante("Diego", 15, 13),
                new Universidad.Estudiante("Sandra", 10, 7),
                new Universidad.Estudiante("Pablo", 14, 14),
                new Universidad.Estudiante("Andrés", 25, 21),
                new Universidad.Estudiante("Clara", 28, 27),
                new Universidad.Estudiante("Esteban", 30, 29),
                new Universidad.Estudiante("Sofía", 30, 25),
                new Universidad.Estudiante("Marta", 22, 20),
                new Universidad.Estudiante("Rosa", 16, 12),
                new Universidad.Estudiante("Tomás", 14, 10),
                new Universidad.Estudiante("Victoria", 18, 17),
                new Universidad.Estudiante("Luis", 12, 11)
            };

// Mostrar la información de cada estudiante
foreach (var estudiante in estudiantes)
{
    estudiante.MostrarInformacion();
}

// Mostrar reportes
estudiantes.MostrarReporteAprobados();
estudiantes.MostrarReporteNoAprobados();