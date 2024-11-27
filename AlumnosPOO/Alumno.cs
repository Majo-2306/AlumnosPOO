namespace AlumnosPOO
{
    //estos son campos
    internal class Alumno
    {
         string nombre;
         string grupo;
         string contrasena;

        //constructor
        public Alumno(string nombre)
        {
           this.nombre = nombre;
        }

        //LAS PROPIEDADES SE ESCRIBEN EN MAYUSCULA

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Grupo
        {
            get
            {
                return grupo;
            }
            set
            {
                grupo = value;
            }
        }
        public string Contrasena
        {
            get
            {
                return contrasena;
            }
            set
            {
                grupo = value;
            }
        }

    }
}
