namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        String nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public int AnioCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public List<Curso> curso { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public Escuela(string nombre, int anioCreacion)
        {
            this.nombre = nombre;
            AnioCreacion = anioCreacion;
        }

        //Constructor ecundario 
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AnioCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        //Método ToString
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} y Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}