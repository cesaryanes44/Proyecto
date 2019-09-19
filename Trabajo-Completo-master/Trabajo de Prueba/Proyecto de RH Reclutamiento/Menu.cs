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
    public partial class FrmMenu : Form
    {
        AspirantesBL _aspirantesBL;
        TituloBL _tituloBL;
        AreaBL _areaBL;
        PuestoBL _puestoBL;
        NivelInglesBL _nivelInglesBL;
        UsuariosBL _usuariosBL;
        FacturaBL _facturaBL;

        public FrmMenu()
        {
            InitializeComponent();
            _aspirantesBL = new AspirantesBL();
            _tituloBL = new TituloBL();
            _areaBL = new AreaBL();
            _puestoBL = new PuestoBL();
            _nivelInglesBL = new NivelInglesBL();
            _usuariosBL = new UsuariosBL();
            _facturaBL = new FacturaBL();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rrporteDeAspirantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFrmReporteAspirantes = new FrmReporteAspirantes();
            formFrmReporteAspirantes.MdiParent = this;

            formFrmReporteAspirantes.cargarDatos(_aspirantesBL, _tituloBL, _areaBL, _nivelInglesBL);
            formFrmReporteAspirantes.Show();
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formArea = new Area();
            formArea.MdiParent = this;

            formArea.cargarDatos(_areaBL);
            formArea.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPuesto = new Puesto();
            formPuesto.MdiParent = this;

            formPuesto.cargarDatos(_puestoBL);
            formPuesto.Show();

        }

        private void aspiranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAspirante = new Aspirantes();
            formAspirante.MdiParent = this;

            formAspirante.cargarDatos(_aspirantesBL, _tituloBL, _areaBL, _nivelInglesBL);
            formAspirante.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.CargarDatos(_usuariosBL);
            login.ShowDialog();

            areasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerAreas;

            puestosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerPuestos;
            aspiranteToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReporteDeAspirantes;

            proximamenteToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerBusquedaDeEmpleados;
            adicionDeEmpleadosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerAdicionDeEmpleados;
            contratacionToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerContratacion;

            rrporteDeAspirantesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReporteDeAspirantes;
            reporteDeAspirantesContratadosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReporteDeAspiratesContratados;

            verLaAyudaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerLaAyuda;
            acercaDeRecursosHumanosReclutamientoToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerAcercaDeRecursosHumanos;





        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu.ActiveForm.Close();
        }

        private void acercaDeRecursosHumanosReclutamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAyuda frm = new FrmAyuda();
            frm.Show();
        }

        private void proximamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmBusqueda = new FrmBusqueda();
            FrmBusqueda.MdiParent = this;

            FrmBusqueda.Show();
        }

        private void adicionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmAddAspirantes = new FrmAddAspirantes();
            FrmAddAspirantes.MdiParent = this;

            FrmAddAspirantes.cargarDatos(_aspirantesBL, _tituloBL, _areaBL, _nivelInglesBL);
            FrmAddAspirantes.Show();
        }

        private void contratacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmContratados = new FrmContratados();
            FrmContratados.MdiParent = this;

            FrmContratados.cargarDatos(_aspirantesBL);
            FrmContratados.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmFactura = new FrmFactura();
            FrmFactura.MdiParent = this;

            FrmFactura.Show();
        }

        private void reporteDeAspirantesContratadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteAspirantes = new FormReporteAspirates();
            formReporteAspirantes.MdiParent = this;
            formReporteAspirantes.CargarDatos(_aspirantesBL);

            formReporteAspirantes.Show();


        }

        private void reporteTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteTotales = new FormReporteTotales();
            formReporteTotales.CargarDatos(_facturaBL, _aspirantesBL);
            formReporteTotales.MdiParent = this;

            formReporteTotales.Show();
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmFactura = new FrmFactura();
            frmFactura.MdiParent = this;

            frmFactura.cargarDatos(_facturaBL, _aspirantesBL, _puestoBL, _areaBL);
            frmFactura.Show();
        }
    }
}
