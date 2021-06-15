using System;

namespace practica04.Models
{
    public class usuario
    {
        public int id { get; set; }

        public string nombre { get; set; }
        public string nombreusuario { get; set; }


        public string foto { get; set; }

        public string descripcion { get; set; }

        public DateTime fecharegistr { get; set; }



        public usuario()
        {
            fecharegistr = DateTime.Now;
        }

    }
}