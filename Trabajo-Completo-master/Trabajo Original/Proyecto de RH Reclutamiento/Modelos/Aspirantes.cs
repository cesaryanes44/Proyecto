using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class Aspirantes //Curriculum
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Identidad { get; set; }

        public int AreaId { get; set; }
        public int TituloId { get; set; }
        public int NivelInglesId { get; set; }

        public string Experiencia { get; set; }
        public string Direccion { get; set; }
        public NivelIngles NivelIngles { get; set; }
        public Titulo Titulo { get; set; }
        public int SalarioqueQuiereGanar { get; set; }
        public Area Area { get; set; }
        public bool Actividad { get; set; }
        public byte[] Foto { get; set; }
        public int Existencia { get; set; }

        public Aspirantes()
        {


            Titulo = new Titulo(1, "Adminitracion de Empresas");
            TituloId = Titulo.Id;

            Area = new Area(1, "Administracion");
            AreaId = Area.Id;

            NivelIngles = new NivelIngles(1, "Ninguno ");
            NivelInglesId = NivelIngles.Id;
        }

        public Aspirantes(int id, string nombre, int edad, string identidad, string experiencia, string direccion, NivelIngles nivelingles, Titulo titulo, int salarioQueQuiereGanar, Area area)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Identidad = identidad;          
            Experiencia= experiencia;
            Direccion = direccion;
            NivelIngles = nivelingles;
            Titulo = titulo;
            SalarioqueQuiereGanar = salarioQueQuiereGanar;
            Area = area;
            Actividad = true;
            AreaId = area.Id;
            TituloId = titulo.Id;
            NivelInglesId = nivelingles.Id;
        }
    }


}
