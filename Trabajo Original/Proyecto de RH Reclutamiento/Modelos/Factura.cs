using Proyecto_de_RH_Reclutamiento.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public Compañia Compañia { get; set; }
        public int CompañiaId { get; set; }

        public double CantAspirantes { get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
         
        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FacturaDetalle>();
        }

        public void CalcularTotalFactura()
        {
            var aspirantesBL = new AspirantesBL();

            double subtotal = 0;
            foreach (var detalle in FacturaDetalle)
            {
                //var salario = aspirantesBL.ObtenerSalario(detalle.AspiranteId);

                subtotal = subtotal + detalle.CalcularTotalDetalle();
            }

            double cantidad = 0;
            foreach (var aspirante in FacturaDetalle)
            {
                cantidad = cantidad + aspirante.CalcularCantAsp();
            }

            double comision = 0;
            foreach (var comisiones in FacturaDetalle)
            {
                comision = comision + comisiones.CalcularComision();
            }

            CantAspirantes = cantidad;
            
            //Cantidad Total de comisiones mensual
            SubTotal = comision;

            //Cantidad Total de comisiones sumando los 3 meses
            Total = SubTotal * 3;
        }

    }

        public class FacturaDetalle
        {
            public int Id { get; set; }

            public int AspiranteId { get; set;  }
            public Aspirantes Aspirante { get; set; }

            public int AreaId { get; set; }
            public Area Area { get; set; }

            public int PuestoId { get; set; }
            public Puesto Puesto { get; set; }
         
            

            public int Cantidad { get; set; }

            public double CantDeSal { get; set; }
            public double Salario { get; set; }
            public double Comision { get; set; }
            public double Total { get; set; }

            public FacturaDetalle()
            {
                Cantidad = 1;
                CantDeSal = 3;
                AspiranteId = 1;
                AreaId = 1;
                PuestoId = 1;         
        }           
            
            /*Se toma en cuenta el salario que ganara por la comision que se cobrara, 
            multipicandolo por la cantidad de salarios que se tomaran*/
            public double CalcularTotalDetalle( )
            {              
                Total = (Salario * 0.50)*CantDeSal;

                return Total;               
            }
            
            //Se toma el Salario para multiplicarlo por el 50% y asi sacar la comision
            public double CalcularComision()
            {
                Comision = (Salario * 0.50);

                return Comision;
            }
                    

            /*Se suman el total de aspirantes para sacar un total al final y obtener 
            la cantidad de comisiones completa por todos los aspirantes*/
            public double CalcularCantAsp()
            {
                double detalle = 0;
                detalle = Cantidad;

                return detalle;
            }

        }
}
