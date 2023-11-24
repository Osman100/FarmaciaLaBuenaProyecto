using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RTarjetaCredito: BaseInterface<TarjetaCredito>
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idTarjeta;
        public int idCliente;
        public string numeroTarjeta;

        public List<TarjetaCredito> getAll()
        {
             return db.TarjetaCredito.ToList();
        }   

        public int create(TarjetaCredito model)
        {
            try
            {
                TarjetaCredito tarjetaCredito = new TarjetaCredito
                {
                    idCliente = model.idCliente,
                    numeroTarjeta = model.numeroTarjeta,
                };

                db.TarjetaCredito.Add(tarjetaCredito);
                db.SaveChanges();

                return tarjetaCredito.idTarjeta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(TarjetaCredito model)
        {
            try
            {
                TarjetaCredito tarjetaCredito = db.TarjetaCredito.Find(model.idTarjeta);
                tarjetaCredito.idCliente = model.idCliente;
                tarjetaCredito.numeroTarjeta = model.numeroTarjeta;

                db.Entry(tarjetaCredito).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return tarjetaCredito.idTarjeta;
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
                TarjetaCredito tarjetaCredito = db.TarjetaCredito.Find(id);
                db.TarjetaCredito.Remove(tarjetaCredito);
                db.SaveChanges();

                return tarjetaCredito.idTarjeta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }


    }
}
