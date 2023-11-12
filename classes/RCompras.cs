using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Compra compra = db.Compra.Find(recordID);
                db.Compra.Remove(compra);
                db.SaveChanges();

                return compra.idCompra;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }


    }
}
