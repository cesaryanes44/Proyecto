using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class NivelIngles
    {
        public int Id { get; set; }
        public string Nivel { get; set; }

        public NivelIngles()
        {

        }

        public NivelIngles(int id, string nivel)
        {
            Id = id;
            Nivel = nivel;
        }
    }
}
