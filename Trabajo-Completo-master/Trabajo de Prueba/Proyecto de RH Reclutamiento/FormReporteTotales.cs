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
    public partial class FormReporteTotales : Form
    {
        public FormReporteTotales()
        {
            InitializeComponent();
            
        }
        public void CargarDatos(FacturaBL facturaBL, AspirantesBL aspirantesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from F in facturaBL.ListadeFacturas
                select new
                {
                    Id = F.Id,
                    Fecha = F.Fecha,
                    Compania = F.Compañia,
                    Aspirante = F.CantAspirantes,
                    Subtotal = F.SubTotal,
                    Impuesto = F.Impuesto,
                    Total = F.Total,
                    Activo = F.Activo
                    
                };

            var reporte = new ReporteFactura();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
  }
