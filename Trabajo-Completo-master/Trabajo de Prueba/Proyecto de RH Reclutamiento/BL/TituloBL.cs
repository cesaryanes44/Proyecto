using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class TituloBL
    {
        public BindingList<Titulo> ListaDeTitulos { get; set; }

        public TituloBL()
        {
            ListaDeTitulos = new BindingList<Titulo>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            //TITULO
            var tit1 = new Titulo(1,"Administracion de Empresas");
            var tit2 = new Titulo(2,"Bachillerato Ciencias Y Letras");
            var tit3 = new Titulo(3,"Contaduria Publica");
            var tit4 = new Titulo(4,"Control de Calidad");
            var tit5 = new Titulo(5,"Comercio");
            var tit6 = new Titulo(6,"Cooperativismo");
            var tit7 = new Titulo(7,"Economia");
            var tit8 = new Titulo(8,"Hostelería y Turismo");
            var tit9 = new Titulo(9,"Informatica");
            var tit10 = new Titulo(10,"Informatica Administrativa");
            var tit11 = new Titulo(11,"Ingenieria En Computacion");
            var tit12 = new Titulo(12,"Ingenieria Electrica");
            var tit13 = new Titulo(13,"Inenieria En Sistemas");
            var tit14 = new Titulo(14,"Perito Mercantil");
            var tit15 = new Titulo(15,"Tecnico en Computacion");
            var tit16 = new Titulo(16,"Tecnico en Refrigeracion");

            ListaDeTitulos.Add(tit1);
            ListaDeTitulos.Add(tit2);
            ListaDeTitulos.Add(tit3);
            ListaDeTitulos.Add(tit4);
            ListaDeTitulos.Add(tit5);
            ListaDeTitulos.Add(tit6);
            ListaDeTitulos.Add(tit7);
            ListaDeTitulos.Add(tit8);
            ListaDeTitulos.Add(tit9);
            ListaDeTitulos.Add(tit10);
            ListaDeTitulos.Add(tit11);
            ListaDeTitulos.Add(tit12);
            ListaDeTitulos.Add(tit13);
            ListaDeTitulos.Add(tit14);
            ListaDeTitulos.Add(tit15);
            ListaDeTitulos.Add(tit16);

        }
    }
}
