using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class CompañiaBL
    {
        public BindingList<Modelos.Compañia> ListaDeCompañia { get; set; }

        public CompañiaBL()
        {
            ListaDeCompañia = new BindingList<Modelos.Compañia>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var comp1 = new Modelos.Compañia(1, "Serveceria Hondureña ");
            var comp2 = new Modelos.Compañia(2, "Pro Carnes ");
            var comp3 = new Modelos.Compañia(3, "UnahVs ");
            var comp4 = new Modelos.Compañia(4, "Megapaca ");
            var comp5 = new Modelos.Compañia(5, "Acosa ");

            ListaDeCompañia.Add(comp1);
            ListaDeCompañia.Add(comp2);
            ListaDeCompañia.Add(comp3);
            ListaDeCompañia.Add(comp4);
            ListaDeCompañia.Add(comp5);
            
        }


    }
}
