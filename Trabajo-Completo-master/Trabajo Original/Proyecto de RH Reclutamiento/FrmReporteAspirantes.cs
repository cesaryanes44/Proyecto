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
    public partial class FrmReporteAspirantes : Form
    {
        public FrmReporteAspirantes()
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


        private void listaDeAspirantesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmReporteAspirantes_Load(object sender, EventArgs e)
        {

        }
    }
}
