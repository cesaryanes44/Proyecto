using Proyecto_de_RH_Reclutamiento.BL;
using Proyecto_de_RH_Reclutamiento.Modelos;
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
    public partial class FrmFactura : Form
    {
        FacturaBL _facturaBL;
        public FrmFactura()
        {
            InitializeComponent();          
        }

        public void cargarDatos(FacturaBL facturaBL, AspirantesBL aspirantesBL, PuestoBL puestoBL, AreaBL areaBL, CompañiaBL compañiaBL)
        {
            _facturaBL = facturaBL;

            listadeFacturasBindingSource.DataSource = facturaBL.ListadeFacturas;
            listaDeAspirantesBindingSource.DataSource = aspirantesBL.ListaDeContratados;
            listaDePuestosBindingSource.DataSource = puestoBL.ListaDePuestos;
            listaDeAreasBindingSource.DataSource = areaBL.ListaDeAreas;
            listaDeCompañiaBindingSource.DataSource = compañiaBL.ListaDeCompañia;
                                                      
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularTotalFactura();

            listadeFacturasBindingSource.ResetBindings(false);

        }

        private void facturaDetalleDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
