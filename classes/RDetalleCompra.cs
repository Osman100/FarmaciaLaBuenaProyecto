using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RDetalleCompra
    {

        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idDetalleCompra { get; set; }
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }

        public List<DetalleCompra> getAll()
        {
            return db.DetalleCompra.ToList();
            
        }

        public int create(DetalleCompra model)
        {
            try
            {
                DetalleCompra detalleCompra = new DetalleCompra();
                detalleCompra.idCompra = model.idCompra;
                detalleCompra.idProducto = model.idProducto;
                detalleCompra.cantidadProducto = model.cantidadProducto;
                detalleCompra.subtotal = model.subtotal;

                

                db.DetalleCompra.Add(detalleCompra);
                db.SaveChanges();

                return detalleCompra.idDetalleCompra;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return -1;
            }
        }

        public int update(DetalleCompra model)
        {
            try
            {
                DetalleCompra detalleCompra = db.DetalleCompra.Find(model.idDetalleCompra);
                detalleCompra.idDetalleCompra = model.idDetalleCompra;
                detalleCompra.idCompra = model.idCompra;
                detalleCompra.idProducto = model.idProducto;
                detalleCompra.cantidadProducto = model.cantidadProducto;
                detalleCompra.subtotal = model.subtotal;

                db.Entry(detalleCompra).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return detalleCompra.idDetalleCompra;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int delete(int id)
        {
            try
            {
                DetalleCompra detalleCompra = db.DetalleCompra.Find(id);
                db.DetalleCompra.Remove(detalleCompra);
                db.SaveChanges();

                return detalleCompra.idDetalleCompra;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public List<VistaDetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            
                List<VistaDetalleCompra> detallesCompra = db.VistaDetalleCompra
                                                                .Where(detalle => detalle.ID == idCompra)
                                                                .ToList();
                return detallesCompra;
            
        }
        public decimal CalcularTotalCompra(int idCompra)
        {
            List<VistaDetalleCompra> detalleCompra = ObtenerDetalleCompra(idCompra);
            decimal totalCompra = detalleCompra.Sum(detalle => detalle.Total);
            return totalCompra;
        }

    }

}
