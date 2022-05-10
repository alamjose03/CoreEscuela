using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academay", 2012, TiposEscuela.Primaria,
            ciudad: "Bogotá", pais: "Colombia"
            );
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            Random rnd = new Random();
            foreach (var curso in Escuela.curso)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            var nota = rnd.Next(0,5);
                            var ev =new Evaluaciones
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre}",
                                Nota = nota,
                                Alumno = alumno,

                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private List<Alumno> CargarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1}{n2}{a1}" };
            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.curso)
            {
                var listaAsignaturas = new List<Asignatura>(){
                new Asignatura(){Nombre = "Matematicas" },
                new Asignatura(){Nombre = "Educacion fisica",},
                new Asignatura(){Nombre = "Castellano",},
                new Asignatura(){Nombre = "Ciencias Naturales",},

                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private void CargarCursos()
        {
            Escuela.curso = new List<Curso>(){
                new Curso(){Nombre = "012", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "013", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "014", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "015", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "016", Jornada = TiposJornada.Tarde}
            };


            Random rnd = new Random();
            foreach (var curso in Escuela.curso)
            {
                int cantRandom = rnd.Next(5, 20);
                curso.Alumnos = CargarAlumnos(cantRandom);
            }
        }
    }
}
