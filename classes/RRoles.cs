using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    
    internal class RRoles: BaseInterface<Rol>
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idRol { get; set; }
        public string nombreRol { get; set; }

        public List<Rol> getAll()
        {
            return db.Rol.ToList();
        }

        public int create(Rol model)
        {
            try
            {
                Rol rol = new Rol
                {
                    nombreRol = model.nombreRol,
                };

                db.Rol.Add(rol);
                db.SaveChanges();

                return rol.idRol;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(Rol model)
        {
               try
            {
                Rol rol = db.Rol.Find(model.idRol);
                rol.nombreRol = model.nombreRol;

                db.Entry(rol).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return rol.idRol;
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
                Rol rol = db.Rol.Find(id);
                db.Rol.Remove(rol);
                db.SaveChanges();

                return rol.idRol;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

    }
}
