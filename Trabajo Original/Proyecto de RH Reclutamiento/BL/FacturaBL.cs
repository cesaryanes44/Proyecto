using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListadeFacturas { get; set; }
        public BindingList<FacturaDetalle> ListadeDetalleFacturas { get; set; }
        public int NumeroFactura { get; set; }

        public FacturaBL()
        {
            ListadeFacturas = new BindingList<Factura>();
            ListadeDetalleFacturas = new BindingList<FacturaDetalle>();
            NumeroFactura = 1;
        }

        public void NuevaFactura()
        {
            var nuevaFactura = new Factura();
            nuevaFactura.Id = NumeroFactura;

            ListadeFacturas.Add(nuevaFactura);
            NumeroFactura += 1;

        }
         
    }
}
