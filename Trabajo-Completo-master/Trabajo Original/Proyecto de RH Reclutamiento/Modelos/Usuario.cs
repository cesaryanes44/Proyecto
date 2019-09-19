using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }


        public bool PuedeVerAreas { get; set; }
        public bool PuedeVerPuestos { get; set; }
        public bool PuedeVerAspirante { get; set; }


        public bool PuedeVerBusquedaDeEmpleados { get; set; }
        public bool PuedeVerAdicionDeEmpleados { get; set; }
        public bool PuedeVerContratacion{ get; set; }


        public bool PuedeVerReporteDeAspirantes { get; set; }
        public bool PuedeVerReporteDeAspiratesContratados { get; set; }

        public bool PuedeVerLaAyuda { get; set; }
        public bool PuedeVerAcercaDeRecursosHumanos { get; set; }

        public bool PuedeVerFacturas { get; set; }

        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;

        }


    }
}
