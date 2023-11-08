using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RProveedores
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string direccionProveedor { get; set; }
        public string telefonoProveedor { get; set; }
        public string correoProveedor { get; set; }
        public string estadoProveedor { get; set; }

        public List<Proveedor> getAll()
        {
            return db.Proveedor.ToList();
        }

        public int create(Proveedor model)
        {
            try
            {
                Proveedor proveedor = new Proveedor
                {
                    nombreProveedor = model.nombreProveedor,
                    
                    telefonoProveedor = model.telefonoProveedor,
                    
                };

                db.Proveedor.Add(proveedor);
                db.SaveChanges();

                return proveedor.idProveedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(Proveedor model)
        {
            try
            {
                Proveedor proveedor = db.Proveedor.Find(model.idProveedor);
                proveedor.nombreProveedor = model.nombreProveedor;
                
                proveedor.telefonoProveedor = model.telefonoProveedor;
               

                db.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return proveedor.idProveedor;
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
                Proveedor proveedor = db.Proveedor.Find(id);
                db.Proveedor.Remove(proveedor);
                db.SaveChanges();

                return proveedor.idProveedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
