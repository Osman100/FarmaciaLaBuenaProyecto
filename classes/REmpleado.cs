using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

namespace La_Buena_Farmacia.classes
{
    public class REmpleado: BaseInterface<Empleado>
    {

        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idEmpleado { get; set; }

        public int idRol { get; set; }
        public string nombreEmpleado { get; set; }

        public string estadoLaboral { get; set; }

        public decimal salario { get; set; }
        public string EmpleadoPassword { get; set; }
        public string apellido { get; set; }

        public List<Empleado> getAll()
        {
            return db.Empleado.ToList(); 


           

        }

        public int create(Empleado model)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    nombreEmpleado = model.nombreEmpleado,
                    estadoLaboral = model.estadoLaboral,
                    salario = model.salario,
                    empleadoPassword = model.empleadoPassword,
                    idRol = model.idRol,

                };

                db.Empleado.Add(empleado);
                db.SaveChanges();

                return empleado.idEmpleado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int update(Empleado model)
        {
            try
            {
                // Obtener el empleado de la base de datos según el ID
                Empleado empleado = db.Empleado.FirstOrDefault(e => e.idEmpleado == model.idEmpleado);

                if (empleado != null)
                {
                    // Actualizar los campos con los nuevos valores del objeto updatedEmpleado
                    empleado.nombreEmpleado = model.nombreEmpleado;
                    empleado.idRol = model.idRol;
                    empleado.estadoLaboral = model.estadoLaboral;
                    empleado.salario = model.salario;

                    // Guardar los cambios en la base de datos
                    return db.SaveChanges();
                }
                else
                {
                    // El empleado no se encontró en la base de datos
                    return -1;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir al actualizar
                Console.WriteLine(ex.Message);
                return -1; // Devuelve un valor negativo en caso de error
            }



        }

        public int delete(int recordID)
        {
            var registro = db.Empleado.Find(recordID);
            db.Empleado.Remove(registro);
            return db.SaveChanges();
        }


        public bool login(REmpleado model)
        {
            string password = model.EmpleadoPassword;
            string passwordHash = this.MD5Hash(password);
            model.EmpleadoPassword = passwordHash;
            string nombre = model.nombreEmpleado;

            var usuarioEncontrado = db.Empleado.FirstOrDefault(u => u.nombreEmpleado == nombre && u.empleadoPassword == passwordHash);
            if(usuarioEncontrado != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;

            // Formatear el resultado en el mismo formato que SQL Server
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2")); // Convierte a mayúsculas
            }
            return str.ToString();
        }


    }

}
