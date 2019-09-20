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
    public partial class Puesto : Form
    {
        public Puesto()
        {
            InitializeComponent();
        }
        public void cargarDatos(PuestoBL puestoBL)
        {        
            listaDePuestosBindingSource.DataSource = puestoBL.ListaDePuestos;
        }

        private void Puesto_Load(object sender, EventArgs e)
        {

        }
    }
}
