using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ConexionN
    {
        Conexion cn = new Conexion();

        public int conSQL(string user, string pass)
        {
            return cn.consultaLogin(user, pass);
        }

        public DataTable ConsultarDT()
        {
            return cn.ConsultaUsuariosDG();
        }

        public int InsertarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            return cn.InsertarUsuario(nom,apel,dni,tel,user,pass);
        }

        public int ModificarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            return cn.ModificarUsuario(nom, apel, dni, tel, user, pass);
        }

        public int EliminarUsuario(string dni)
        {
            return cn.EliminarUsuario(dni);
        }
    }
}
