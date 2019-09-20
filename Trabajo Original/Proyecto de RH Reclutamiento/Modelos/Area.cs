using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class Area
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Area()
        {

        }
        public Area(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }


     }   
}
