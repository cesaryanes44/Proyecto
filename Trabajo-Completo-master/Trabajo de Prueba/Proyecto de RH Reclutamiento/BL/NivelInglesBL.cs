using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class NivelInglesBL
    {
            public BindingList<Modelos.NivelIngles> ListaDeNivel { get; set; }

            public NivelInglesBL()
            {
                 ListaDeNivel = new BindingList<Modelos.NivelIngles>();
                 CrearDatosdePrueba();
            }

            private void CrearDatosdePrueba()
            {
                var nivel1 = new Modelos.NivelIngles(1, "Ninguno ");
                var nivel2 = new Modelos.NivelIngles(2, "Basico  ");
                var nivel3 = new Modelos.NivelIngles(3, "Normal");
                var nivel4 = new Modelos.NivelIngles(4, "Avanzado");


                 ListaDeNivel.Add(nivel1);
                 ListaDeNivel.Add(nivel2);
                 ListaDeNivel.Add(nivel3);
                 ListaDeNivel.Add(nivel4);
        }
   }
}
