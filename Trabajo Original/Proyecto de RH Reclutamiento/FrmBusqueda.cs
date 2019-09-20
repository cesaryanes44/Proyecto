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
    public partial class FrmBusqueda : Form
    {
        AspirantesBL _aspirantesBL;
        public FrmBusqueda()
        {
            InitializeComponent();

            _aspirantesBL = new AspirantesBL();
            listaDeAspirantesBindingSource.DataSource = _aspirantesBL.ListaDeAspirantes;
            listaDeBuscarbindingSource1.DataSource = _aspirantesBL.ListaDeBuscar;

        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aspirantesBL = new AspirantesBL();
            var texto = textBox1.Text;

            var aspirantes = (Modelos.Aspirantes)listaDeAspirantesBindingSource.Current;
            aspirantesBL.Busqueda(aspirantes, textBox1.Text);

            listaDeAspirantesBindingSource.ResetBindings(false);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
