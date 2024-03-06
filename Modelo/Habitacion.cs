using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplito.Modelo
{
    internal class Habitacion
    {

        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public int Id { set; get; }
        public bool estaOcupada { set; get; }

        public Habitacion(int id, string n, string desc) { 
            this.Nombre = n;
            this.Descripcion = desc;
            this.Id = id;
        }

        public Habitacion(string h) {
            string[] datos = h.Split('+');
            try {
                this.Id = int.Parse(datos[0]);
                Nombre = datos[1];
                Descripcion = datos[2];
            }catch(Exception ex) {
                Trace.WriteLine(ex.Message);
            }
           

        }
        public Habitacion() { }
    }
}
