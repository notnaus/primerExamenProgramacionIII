namespace primerExamenProgramacionIII.Models
{
    public class ListaProfesores
    {
        //Se crea la lista para almacenar a los profesores
        public List<Profesor> Profesor { get; set; }
        public static ListaProfesores Lalista = new ListaProfesores();

        private ListaProfesores()
        {
            // Se agregan nuevos profesores usando la funcion Agregar Profesor
            Profesor = new List<Profesor>();
            AgregarProfesor(
                118270487,
                "Jossue",
                "Rodriguez",
                "Estudios Sociales");
            AgregarProfesor(
                134270487,
                "Valeria",
                "Alvarado",
                "Ciencias");
        }

        public void AgregarProfesor( int cedula, string nombre, string apellido, string area)
        {
            // Se crea la funcion para almacenar nuevos Profesores y asignarlos a las distintas variables
            Profesor p = new Profesor();
            p.Cedula = cedula;
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.AreadeConocimiento = area;
            p.Id = 0;

            var pl = Profesor.OrderByDescending(x => x.Id).FirstOrDefault();
            p.Id = pl?.Id + 1 ?? 0; // Si pl no es nulo. id + 1, si no 0

            Profesor.Add(p);
        }



    }
}
