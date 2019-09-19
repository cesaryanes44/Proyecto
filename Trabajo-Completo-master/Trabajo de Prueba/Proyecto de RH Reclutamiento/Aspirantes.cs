using Proyecto_de_RH_Reclutamiento.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_RH_Reclutamiento
{
    public partial class Aspirantes : Form
    {
        public Aspirantes()
        {
            InitializeComponent();

        }
        public void cargarDatos(AspirantesBL aspirantesBL, TituloBL tituloBL, AreaBL areaBL, NivelInglesBL nivelInglesBL)
        {

            listaDeAspirantesBindingSource.DataSource = aspirantesBL.ListaDeAspirantes;
            listaDeTitulosBindingSource.DataSource = tituloBL.ListaDeTitulos;
            listaDeAreasBindingSource.DataSource = areaBL.ListaDeAreas;
            listaDeNivelBindingSource.DataSource = nivelInglesBL.ListaDeNivel;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void edadLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if (archivo != "")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
