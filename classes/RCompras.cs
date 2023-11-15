using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Buena_Farmacia.classes
{
    internal class RCompras
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idCompra { get; set; }
        public int idProveedor { get; set; }
        public string tipoCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public decimal totalCompra { get; set; }


        public List<Compra> getAll()
        {
            return db.Compra.ToList();
        }

        public int create(Compra model)
        {
            try
            {
                Compra compra = new Compra
                {
                    idProveedor = model.idProveedor,
                    tipoCompra = model.tipoCompra,
                    fechaCompra = model.fechaCompra,
                    totalCompra = model.totalCompra,
                };

                db.Compra.Add(compra);
                db.SaveChanges();

                return compra.idCompra;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Exception innerException = ex.InnerException;

                // Puedes imprimir los detalles en la consola o en algún otro lugar
                Console.WriteLine("Mensaje de la excepción interna: " + innerException.Message);
                Console.WriteLine("Detalles de la excepción interna: " + innerException.ToString());
                return -1;
            }
        }

        public int update(Compra model)
        {
            try
            {
                Compra compra = db.Compra.Find(model.idCompra);
                compra.idProveedor = model.idProveedor;
                compra.tipoCompra = model.tipoCompra;
                compra.fechaCompra = model.fechaCompra;
                compra.totalCompra = model.totalCompra;

                db.Entry(compra).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return compra.idCompra;
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
                // Eliminar detalles de compra asociados
                var detalles = db.DetalleCompra.Where(detalle => detalle.idCompra == idCompra);
                db.DetalleCompra.RemoveRange(detalles);

                // Eliminar la compra
                var compra = db.Compra.Find(idCompra);
                db.Compra.Remove(compra);

                // Guardar cambios en la base de datos
                db.SaveChanges();

                return compra.idCompra;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        private Compra ObtenerCompraPorId(int idCompra)
        {

                // Utiliza Entity Framework para obtener la compra según el ID de compra
                Compra compra = db.Compra.FirstOrDefault(c => c.idCompra == idCompra);
                return compra;
            
        }

        public void ActualizarTotalCompra(int idCompra, decimal total)
        {
            Compra compra = ObtenerCompraPorId(idCompra);

            if (compra != null)
            {
                compra.totalCompra = total;

                db.Entry(compra).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                
            }
        }

        public int ObtenerIdProveedorPorNombre(string nombreProveedor)
        {
            // Realiza la consulta a la base de datos para obtener el ID del proveedor en base al nombre
            Proveedor proveedor = db.Proveedor.FirstOrDefault(p => p.nombreProveedor == nombreProveedor);

            // Devuelve el ID del proveedor si se encuentra, de lo contrario, devuelve -1
            return proveedor != null ? proveedor.idProveedor : -1;
        }


    }
}
