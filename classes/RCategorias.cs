using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RCategorias
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }

        public List<Categoria> getAll()
        {
            return db.Categoria.ToList();

        }

        public int create(Categoria model)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    nombreCategoria = model.nombreCategoria,
                };

                db.Categoria.Add(categoria);
                db.SaveChanges();

                return categoria.idCategoria;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(Categoria model)
        {
            try
            {
                Categoria categoria = db.Categoria.Find(model.idCategoria);
                categoria.nombreCategoria = model.nombreCategoria;

                db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return categoria.idCategoria;
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
                Categoria categoria = db.Categoria.Find(recordID);
                db.Categoria.Remove(categoria);
                db.SaveChanges();

                return categoria.idCategoria;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }




        
    }
}
