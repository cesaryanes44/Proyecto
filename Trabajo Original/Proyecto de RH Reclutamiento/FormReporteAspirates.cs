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
    public partial class FormReporteAspirates : Form
    {
        public FormReporteAspirates()
        {
            InitializeComponent();
        }

        public void CargarDatos(AspirantesBL aspirantesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from A in aspirantesBL.ListaDeAspirantes
                select new
                {
                    Foto = A.Foto,
                    Id = A.Id,
                    Nombre = A.Nombre,
                    Area = A.Area.Descripcion,
                    Titulo = A.Titulo.Descripcion,
                    Existencia = A.Existencia
                };

            var reporte = new ReporteAspirantesContratados();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
