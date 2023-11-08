using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RProductos : BaseInterface<Producto>
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idProducto { get; set; }
        public int idCategoria { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioProducto { get; set; }
        public int CantidadStock { get; set; }



        public List<Producto> getAll()
        {
            return db.Producto.ToList();
        }

        public int create(Producto model)
        {
            try
            {
                Producto producto = new Producto
                {
                    idCategoria = model.idCategoria,
                    nombreProducto = model.nombreProducto,
                    precioProducto = model.precioProducto,
                    CantidadStock = model.CantidadStock,
                };

                db.Producto.Add(producto);
                db.SaveChanges();

                return producto.idProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(Producto model)
        {
            try
            {
                Producto producto = db.Producto.Find(model.idProducto);
                producto.idCategoria = model.idCategoria;
                producto.nombreProducto = model.nombreProducto;
                producto.precioProducto = model.precioProducto;
                producto.CantidadStock = model.CantidadStock;

                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return producto.idProducto;
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
                Producto producto = db.Producto.Find(id);
                db.Producto.Remove(producto);
                db.SaveChanges();

                return producto.idProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

    }
}

