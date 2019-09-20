using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class AspirantesBL
    {
        public BindingList<Modelos.Aspirantes> ListaDeAspirantes { get; set; }
        public BindingList<Modelos.Aspirantes> ListaDeContratados { get; set; }
        public BindingList<Modelos.Aspirantes> ListaDeBuscar { get; set; }

        public AspirantesBL()
        {
            ListaDeAspirantes = new BindingList<Modelos.Aspirantes>();
            ListaDeContratados = new BindingList<Modelos.Aspirantes>();
            ListaDeBuscar = new BindingList<Modelos.Aspirantes>();
            CrearDatosdePrueba();
        }

        public double ObtenerSalario(int id)
        {
            double salario = 0;

            foreach (var aspirantes in ListaDeAspirantes)
            {
                if (aspirantes.Id == id)
                {
                    salario = aspirantes.SalarioqueQuiereGanar;
                }

            }

            return salario;
        }

        public void AgregarEmpContratado(Modelos.Aspirantes aspirante)
        {
            var encontrado = false;

            foreach (var contratados in ListaDeContratados)
            {
                if (aspirante.Id == contratados.Id)
                {
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                ListaDeContratados.Add(aspirante);
            }       
        }

        public void RemoverAspirante(Modelos.Aspirantes aspirantes)
        {
            ListaDeAspirantes.Remove(aspirantes);            
        }

        public void RemoverContratado(Modelos.Aspirantes contratados)
        {
            ListaDeContratados.Remove(contratados);
        }

        public void Busqueda(Modelos.Aspirantes aspirantes, string texto)
        {                     
            foreach (var buscar in ListaDeAspirantes)
            {
               if (aspirantes.Nombre.ToLower().Contains(texto.ToLower()))
               {
                    ListaDeBuscar.Add(aspirantes);
               }
            }            
        }

        private void CrearDatosdePrueba()
        {

            //NivelINGLES
            var nivel1 = new Modelos.NivelIngles(1, "Ninguno ");
            var nivel2 = new Modelos.NivelIngles(2, "Basico  ");
            var nivel3 = new Modelos.NivelIngles(3, "Normal");
            var nivel4 = new Modelos.NivelIngles(4, "Avanzado");

            //TITULO
            var tit1 = new Titulo(1, "Administracion de Empresas");
            var tit2 = new Titulo(2, "Bachillerato Ciencias Y Letras");
            var tit3 = new Titulo(3, "Contaduria Publica");
            var tit4 = new Titulo(4, "Control de Calidad");
            var tit5 = new Titulo(5, "Comercio");
            var tit6 = new Titulo(6, "Cooperativismo");
            var tit7 = new Titulo(7, "Economia");
            var tit8 = new Titulo(8, "Hostelería y Turismo");
            var tit9 = new Titulo(9, "Informatica");
            var tit10 = new Titulo(10, "Informatica Administrativa");
            var tit11 = new Titulo(11, "Ingenieria En Computacion");
            var tit12 = new Titulo(12, "Ingenieria Electrica");
            var tit13 = new Titulo(13, "Inenieria En Sistemas");
            var tit14 = new Titulo(14, "Perito Mercantil");
            var tit15 = new Titulo(15, "Tecnico en Computacion");
            var tit16 = new Titulo(16, "Tecnico en Refrigeracion");

            //AREA
            var area1 = new Modelos.Area(1, "Administracion ");
            var area2 = new Modelos.Area(2, "Contaduria  ");
            var area3 = new Modelos.Area(3, "Informatica");
            var area4 = new Modelos.Area(4, "Ingenieria");
            var area5 = new Modelos.Area(5, "Tecnicos");
            var area6 = new Modelos.Area(6, "Ventas");

            //ASPIRANTES

            string Direccion = @"C:\Users\CesarYanes\Desktop\Proyecto\Proyecto\Trabajo Original\Imagenes\usuario-sin-foto.JPG";

            var aspirante0 = new Modelos.Aspirantes(0, " ", 0, " ", " ", " ", nivel1, tit1, 0, area1);

            var fileInfo = new FileInfo(Direccion);
            var fileStream = fileInfo.OpenRead();

            aspirante0.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante1 = new Modelos.Aspirantes(1, "Kevin Javier Rivera Amaya", 22, "0512199700879", "4 años", "Reyes Caballero", nivel4, tit1, 12000, area1);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante1.Foto = Program.imageToByteArray (Image.FromStream(fileStream));

            var aspirante2 = new Modelos.Aspirantes(2, "Kevin Arnaldo Cabañas Ortega", 24, "0512199600589", "6 años", "Reyes Caballero", nivel2, tit2, 10000, area2);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante2.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante3 = new Modelos.Aspirantes(3, "Oscar Jose Rasacasielo Cerrato", 27, "0512199500887", "3 años", "Reyes Caballero", nivel3, tit3, 13000, area1);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante3.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante4 = new Modelos.Aspirantes(4, "Oneida Gabriela Reyes Carranza", 34, "0512199700879", "8 años", "Reyes Caballero", nivel4, tit5, 9000, area3);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante4.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante5 = new Modelos.Aspirantes(5, "Jefry Nohemy Coello Valladares", 44, "0512198907896", "7 años", "Reyes Caballero", nivel1, tit7, 5000, area3);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante5.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante6 = new Modelos.Aspirantes(6, "Aleandra Rosario Paredes Coello", 23,"050519981232", "5 años","Villanueva" ,nivel2, tit9, 5500, area2);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante6.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante7 = new Modelos.Aspirantes(7, "Martha Alejandra Ramirez Rapalo", 35,"0505199800968 ", "6 años","Potrerillos",nivel2, tit5, 6500, area2);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante7.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante8 = new Modelos.Aspirantes(8, "Jorge Carlos Pedroza Altamirano", 28,"0505199800968 ", "4 años","Villanueva",nivel3, tit16, 4500, area6);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante8.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante9 = new Modelos.Aspirantes(9, "Juan Manuel Castellanos Martinez", 45, "0550199800393 ", "8 años","San Pedro Sula",nivel3, tit7, 7000, area3);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante9.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante10 = new Modelos.Aspirantes(10, "Elvis Nahaman Chicas Cruz", 38, "050519990948 ", "7 años","Dos Caminos",nivel2, tit15, 5000, area1);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante10.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante11 = new Modelos.Aspirantes(11, "Rosemary Villareal Ortiz", 49, "0505199000293 ","9 años","La Satelite",nivel2, tit7, 9000, area3);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante11.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante12 = new Modelos.Aspirantes(12, "Leon Scott Kennedy", 33,"0505999902934 ", "5 años","Villanueva",nivel3, tit5, 5200, area2);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante12.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante13 = new Modelos.Aspirantes(13, "Dolores Cruz Martinez", 41,"05051999800394", "6 años","Pimienta",nivel4, tit3, 5100, area1);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante13.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante14 = new Modelos.Aspirantes(14, "Dennis Ivan Marcia Lopez", 23,"05059999123124", "3 años","Santa Cruz",nivel2, tit11, 5100, area5);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante14.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante15 = new Modelos.Aspirantes(15, "Suyapa Dennise Mancia Quiroz", 28,"05059999837485", "4 años","Potrerillos",nivel1, tit16, 4100, area6);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante15.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante16 = new Modelos.Aspirantes(16, "Fernando Raul Yanes Mendoza", 31,"05051990786343", "5 años","Villanueva",nivel2, tit14, 5100, area5);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante16.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante17 = new Modelos.Aspirantes(17, "Cesar Manuel Rodriguez Martinez",29,"050501998765093", "4 años","Dos Caminos",nivel3, tit11, 5100, area5);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante17.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante18 = new Modelos.Aspirantes(18, "Erlin Yanneth Garmendia", 36,"0505019998787234", "6 años","San Pedro Sula",nivel2, tit12, 5000, area5);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante18.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante19 = new Modelos.Aspirantes(19, "Anna Yolani Guzman Lopez", 40,"050501999078323", "6 años","La Paz",nivel3, tit10, 4900, area4);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante19.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante20 = new Modelos.Aspirantes(20, "Edna Maria Martinez Altamirano", 47, "05051998123788", "10 años","La Satelite",nivel3, tit5, 8000, area2);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante20.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante21 = new Modelos.Aspirantes(21, "Juan Jose Rodriguez Chicas", 39,"05051998000968", "7 años","Dos Caminos",nivel2, tit7, 5100, area3);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante21.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante22 = new Modelos.Aspirantes(22, "Daisy Iveth Zaldivar", 22,"05051999876345", "3 años","La Paz",nivel4, tit15, 4400, area4);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante22.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante23 = new Modelos.Aspirantes(23, "Santos Andres Yanes Quiroz", 34,"05050199800968", "4 años","Santa Cruz",nivel3, tit13, 6700, area2);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante23.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante24 = new Modelos.Aspirantes(24, "Kimberly Gissel Alvarez", 33,"0505199809845", "5 años","Pimienta",nivel2, tit10, 5300, area4);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante24.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante25 = new Modelos.Aspirantes(25, "Cesar Jaziel Chicas Yanes", 34,"05051998966245", "6 años","San Pedro Sula",nivel1, tit12, 7400, area5);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante25.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var aspirante26 = new Modelos.Aspirantes(26, "Cesar Jaziel Chicas Yanes", 34,"05051998877564", "6 años","San Antonio",nivel4, tit12, 7400, area5);

            fileInfo = new FileInfo(Direccion);
            fileStream = fileInfo.OpenRead();

            aspirante26.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            ListaDeAspirantes.Add(aspirante0);
            ListaDeAspirantes.Add(aspirante1);
            ListaDeAspirantes.Add(aspirante2);
            ListaDeAspirantes.Add(aspirante3);
            ListaDeAspirantes.Add(aspirante4);
            ListaDeAspirantes.Add(aspirante5);
            ListaDeAspirantes.Add(aspirante6);
            ListaDeAspirantes.Add(aspirante7);
            ListaDeAspirantes.Add(aspirante8);
            ListaDeAspirantes.Add(aspirante9);
            ListaDeAspirantes.Add(aspirante10);
            ListaDeAspirantes.Add(aspirante11);
            ListaDeAspirantes.Add(aspirante12);
            ListaDeAspirantes.Add(aspirante13);
            ListaDeAspirantes.Add(aspirante14);
            ListaDeAspirantes.Add(aspirante15);
            ListaDeAspirantes.Add(aspirante16);
            ListaDeAspirantes.Add(aspirante17);
            ListaDeAspirantes.Add(aspirante18);
            ListaDeAspirantes.Add(aspirante19);
            ListaDeAspirantes.Add(aspirante20);
            ListaDeAspirantes.Add(aspirante21);
            ListaDeAspirantes.Add(aspirante22);
            ListaDeAspirantes.Add(aspirante23);
            ListaDeAspirantes.Add(aspirante24);
            ListaDeAspirantes.Add(aspirante25);

        }

        /*public List<Modelos.Aspirantes> ObtenerEmpleadosActivos(string buscar)
        {
            
            var listaEmpleadosActivos = new List<Modelos.Aspirantes>();

            foreach (var aspirante in ListaDeAspirantes)
            {
                if (aspirante.Nombre.Contains(buscar) == true)
                {
                    listaEmpleadosActivos.Add(aspirante);
                }
            }
            return listaEmpleadosActivos;
        }*/


    }
}

