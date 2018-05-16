using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTime.DAL
{
    public class PerfilDAL
    {
        public static IQueryable<object> getUsuario(string nombreUsuario)
        {
            using (CheckTimeEntities bdd = new CheckTimeEntities())
            {
                var user = bdd.Perfil.Where(a => a.Usuario1 == nombreUsuario);
                return user;
            }
        }
    }
}
