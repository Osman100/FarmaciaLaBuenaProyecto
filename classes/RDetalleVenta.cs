using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RDetalleVenta
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }

        public List<DetalleVenta> getAll()
        {
            return db.DetalleVenta.ToList();

        }

        public int create(DetalleVenta model)
        {
            try
            {
                DetalleVenta detalleVenta = new DetalleVenta();
                detalleVenta.idVenta = model.idVenta;
                detalleVenta.idProducto = model.idProducto;
                detalleVenta.cantidadProducto = model.cantidadProducto;
                detalleVenta.subtotal = model.subtotal;
                
                db.DetalleVenta.Add(detalleVenta);
                db.SaveChanges();
                return detalleVenta.idDetalle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return -1;
            }
        }

        public int update(DetalleVenta model)
        {
            try
            {
                DetalleVenta detalleVenta = db.DetalleVenta.Find(model.idDetalle);
                detalleVenta.idDetalle = model.idDetalle;
                detalleVenta.idVenta = model.idVenta;
                detalleVenta.idProducto = model.idProducto;
                detalleVenta.cantidadProducto = model.cantidadProducto;
                detalleVenta.subtotal = model.subtotal;

                db.Entry(detalleVenta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return detalleVenta.idDetalle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int delete(int recordID)
        {
            try
            {
                DetalleVenta detalleVenta = db.DetalleVenta.Find(recordID);
                db.DetalleVenta.Remove(detalleVenta);
                db.SaveChanges();
                return detalleVenta.idDetalle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }



    }
}
