using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
   public class AreaBL
    {
            public BindingList<Modelos.Area> ListaDeAreas { get; set; }

            public AreaBL()
            {
            ListaDeAreas = new BindingList<Modelos.Area>();
            CrearDatosdePrueba();
            }
            private void CrearDatosdePrueba()
            {
            var area1 = new Modelos.Area(1, "Administracion ");
            var area2 = new Modelos.Area(2, "Contaduria  ");
            var area3 = new Modelos.Area(3, "Informatica");
            var area4 = new Modelos.Area(4, "Ingenieria");
            var area5 = new Modelos.Area(5, "Tecnicos");
            var area6 = new Modelos.Area(6, "Ventas");


            ListaDeAreas.Add(area1);
            ListaDeAreas.Add(area2);
            ListaDeAreas.Add(area3);
            ListaDeAreas.Add(area4);
            ListaDeAreas.Add(area5);
            ListaDeAreas.Add(area6);
        }
   }
}
