using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RVentas
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }
        public int idTarjetaCredito { get; set; }
        public DateTime fechaVenta { get; set; }
        public decimal total { get; set; }

        public List<Venta> getAll()
        {
            return db.Venta.ToList();

        }

        public int create(Venta model)
        {
            try
            {
                Venta venta = new Venta();
                venta.idCliente = model.idCliente;
                venta.idEmpleado = model.idEmpleado;
                venta.fechaVenta = model.fechaVenta;
                venta.total = model.total;

                db.Venta.Add(venta);
                db.SaveChanges();

                return venta.idVenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return -1;
            }
        }

        public int update(Venta model)
        {
            try
            {
                Venta venta = db.Venta.Find(model.idVenta);
                venta.idVenta = model.idVenta;
                venta.idCliente = model.idCliente;
                venta.idEmpleado = model.idEmpleado;
                venta.fechaVenta = model.fechaVenta;
                venta.total = model.total;

                db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return venta.idVenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return -1;
            }
        }

        public int delete(int recordID)
        {
            try
            {
                Venta venta = db.Venta.Find(recordID);
                db.Venta.Remove(venta);
                db.SaveChanges();

                return venta.idVenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
      
        
    }
}
