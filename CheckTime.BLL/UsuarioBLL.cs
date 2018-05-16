using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckTime.DAL;

namespace CheckTime.BLL
{
    public class UsuarioBLL
    {
        public static IQueryable<object> getUsuario(string nombreUsuario)
        {
            var user = UsuarioDAL.getUsuario(nombreUsuario);
            return user;
        }

        public static IQueryable<object> getUsuarios()
        {
            var user = UsuarioDAL.getUsuarios();
            return user;
        }
    }
}
