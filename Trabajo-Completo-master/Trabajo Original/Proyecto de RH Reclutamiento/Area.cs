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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();        
        }
        public void cargarDatos(AreaBL areaBL)
        {           
            listaDeAreasBindingSource.DataSource = areaBL.ListaDeAreas;      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Area_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var areasBL = new AreaBL();
            listaDeAreasBindingSource.DataSource = areasBL.ListaDeAreas;
        }
    }
}
