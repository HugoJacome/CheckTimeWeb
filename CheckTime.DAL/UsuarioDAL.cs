using CheckTime.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTime.DAL
{
    public class UsuarioDAL
    {
        
        public static IQueryable<object> getUsuario (string nombreUsuario)
        {
            using (CheckTimeEntities bdd = new CheckTimeEntities())
            {
                var user = bdd.USUARIO.Where(a => a.Usuario1 == nombreUsuario);                
                return user;
            }
        }

        public static IQueryable<object> getUsuarios()
        {
            CheckTimeEntities bdd = new CheckTimeEntities();

            var user = bdd.USUARIO.Where(a => a.Estado != "E");
            return user;

        }
    }
}
