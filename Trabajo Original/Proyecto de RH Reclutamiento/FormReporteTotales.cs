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
        public void CargarDatos(FacturaBL facturaBL, AspirantesBL aspirantesBL, CompañiaBL compañiaBL)
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource =
                from F in facturaBL.ListadeFacturas 
                select new
                {
                    Id = F.Id,
                    Fecha = F.Fecha,
                    Compañia = compañiaBL.ListaDeCompañia.FirstOrDefault(r => r.Id == F.CompañiaId).Descripcion,
                    Aspirante = F.CantAspirantes,
                    Subtotal = F.SubTotal,
                    Impuesto = F.Impuesto,
                    Total = F.Total,
                    Activo = F.Activo                    
                };

 /*           bindingSource.DataSource = from D in facturaBL.ListadeDetalleFacturas select new
                {
                    Id = D.Id,
                    Aspirante = aspirantesBL.ListaDeContratados.FirstOrDefault(r => r.Id == D.AspiranteId).Nombre,
                    
                };*/



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
