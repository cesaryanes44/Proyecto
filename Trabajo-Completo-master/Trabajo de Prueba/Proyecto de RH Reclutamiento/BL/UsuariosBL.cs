using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
   public  class UsuariosBL
    {

        public BindingList<Usuario> ListaDeUsuarios { get; set; }

        public UsuariosBL()
        {
            ListaDeUsuarios = new BindingList<Usuario>();
            CargarDatosdePrueba();
        }

        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "admin", "123");
            usuarioAdmin.PuedeVerAreas = true;
            usuarioAdmin.PuedeVerPuestos = true;
            usuarioAdmin.PuedeVerAspirante = true;

            usuarioAdmin.PuedeVerBusquedaDeEmpleados = true;
            usuarioAdmin.PuedeVerAdicionDeEmpleados = true;
            usuarioAdmin.PuedeVerContratacion = true;

            usuarioAdmin.PuedeVerReporteDeAspirantes = true;
            usuarioAdmin.PuedeVerReporteDeAspiratesContratados = true;

            usuarioAdmin.PuedeVerLaAyuda = true;
            usuarioAdmin.PuedeVerAcercaDeRecursosHumanos = true;


            var usuarioCaja = new Usuario(2, "caja", "456");
            usuarioCaja.PuedeVerFacturas = true;

            ListaDeUsuarios.Add(usuarioAdmin);
            ListaDeUsuarios.Add(usuarioCaja);


        }

        public Usuario Autenticar (string nombre, string contrasena )
        {
            foreach (var usuario in ListaDeUsuarios)
            { 
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }

            }
            return null;
        }

    }
}
