using Proyecto_de_RH_Reclutamiento.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_RH_Reclutamiento
{
    public partial class FrmAddAspirantes : Form
    {
        public FrmAddAspirantes()
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddAspirantes_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            idTextBox.Enabled = true;
            nombreTextBox.Enabled = true;
            edadTextBox.Enabled = true;
            identidadTextBox.Enabled = true;
            experienciaTextBox.Enabled = true;
            salarioqueQuiereGanarTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            comboBox3.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
