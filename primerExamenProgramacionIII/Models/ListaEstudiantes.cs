namespace primerExamenProgramacionIII.Models
{
    public class ListaEstudiantes
    {
        //Se crea la lista para almacenar los estudiantes
        public List<Estudiante> Estudiante { get; set; }
        public static ListaEstudiantes Lalista = new ListaEstudiantes();

        private ListaEstudiantes()
        {
            
            Estudiante = new List<Estudiante>();
            // Se agregan los estudiantes por medio de la funcion AgregarEstudiante
            AgregarEstudiante(
                118270487,
                "Kiara",
                25,
                "Ing Sistemas",
                2);
            AgregarEstudiante(
                118230487,
                "Pedro",
                21,
                "Ing Sistemas",
                5);
            AgregarEstudiante(
               113430487,
               "Jose",
               20,
               "Admin Empresas",
               1);

        }

        public void AgregarEstudiante(int cedula, string nombre, int edad, string carrera, int Cursos)
        {
            // Funcion para crear un nuevo estudiante y asignarlo a las variables respectivas
            Estudiante p = new Estudiante();
            p.Cedula = cedula;
            p.Nombre = nombre;
            p.Edad = edad;
            p.Carrera = carrera;
            p.CantidadDeCursos = Cursos;
            p.Id = 0;

            var pl = Estudiante.OrderByDescending(x => x.Id).FirstOrDefault();
            p.Id = pl?.Id + 1 ?? 0; // Si pl no es nulo. id + 1, si no 0

            Estudiante.Add(p);
        }
    }
}
