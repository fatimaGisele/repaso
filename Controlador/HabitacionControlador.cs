using ejemplito.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplito.Controlador
{
    internal class HabitacionControlador
    {
        
        public static string ruta = "../../Resources/habitaciones.txt";

        public int getUltimoID()
        {
           
            StreamReader ultimoID = new StreamReader(ruta);
            int ID = 1;
            while (!ultimoID.EndOfStream)
            {
                string hab = ultimoID.ReadLine();
                Habitacion habNueva = new Habitacion(hab);
                ID = habNueva.Id;
            }
            ultimoID.Close();
            return ID+1;
        }
        public bool CrearHabitacion(Habitacion h)
        {
            try
            {
                string txt = h.Id + ","+h.Nombre+","+h.Descripcion;
                StreamWriter archivo =  new StreamWriter(ruta, true);
                archivo.WriteLine(txt);
                archivo.Close();
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
            
        }

        public bool EliminarHabitacion(HabitacionControlador h)
        {
            return true;
        }

        public bool modificarHabitacion(HabitacionControlador h)
        {
            return true;
        }

        public Habitacion GetHabitacion(int id)
        {
            StreamReader ultimoID = new StreamReader(ruta);
            while (!ultimoID.EndOfStream)
            {
                string hab = ultimoID.ReadLine();
                Habitacion habNueva = new Habitacion(hab);
                if(id == habNueva.Id)
                {
                    return habNueva;
                }
                
            }
            ultimoID.Close();
            return new Habitacion();
        }
        public List<Habitacion> GetTodasLasHabitaciones()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();

            StreamReader archivo = new StreamReader(ruta);
            while (!archivo.EndOfStream)
            {
                string hab = archivo.ReadLine();
                Habitacion habNueva = new Habitacion(hab);
                habitaciones.Add(habNueva);
                return habitaciones;
            }
            archivo.Close();
            return habitaciones;
        }

      
    }
}
