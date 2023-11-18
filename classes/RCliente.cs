using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RCliente: BaseInterface<Cliente>
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }

        public string numeroTelefonico { get; set; }
        public string correoElectronico { get; set; }
        
        public List<Cliente> getAll()
        {
            return db.Cliente.ToList();

        }

        public int create(Cliente model)
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    nombreCliente = model.nombreCliente,
                    númeroTelefónico = model.númeroTelefónico,
                    correoElectronico = model.correoElectronico,


                };

                db.Cliente.Add(cliente);
                db.SaveChanges();

                return cliente.idCliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(Cliente model)
        {
            try
            {
                Cliente cliente = db.Cliente.Find(model.idCliente);
                cliente.nombreCliente = model.nombreCliente;
                cliente.númeroTelefónico = model.númeroTelefónico;
                cliente.correoElectronico = model.correoElectronico;

                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return cliente.idCliente;
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
                Cliente cliente = db.Cliente.Find(recordID);
                db.Cliente.Remove(cliente);
                db.SaveChanges();

                return cliente.idCliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
