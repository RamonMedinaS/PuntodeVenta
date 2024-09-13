using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        static string conexionstring = "Data Source=VMDEV01;Initial Catalog=TEST;User ID=sa;Password=adf3q9;Persist Security Info=False;";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultaLogin(string Usuario, string Contrasena)
        {
            int count;
            con.Open();
            string query = "SELECT Count(*) FROM Persona WHERE Usuario ='" + Usuario + "' AND Contrasena = '" + Contrasena + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return count;
        }

        public int InsertarUsuario(string nom,string apel,string dni,string tel,string user,string pass)
        {
            int flag = 0;
            con.Open();
            string query = "INSERT INTO Persona VALUES ('" + nom + "','" + apel + "','" + dni + "','" + tel + "','" + user + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag=cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarUsuario(string nom, string apel, string dni, string tel, string user, string pass)
        {
            int flag = 0;
            con.Open();
            string query = "UPDATE Persona SET Nombre ='" + nom + "', Apellidos ='" + apel + "', dni ='" + dni + "', Telefono ='" + tel + "', Usuario ='" + user + "', Contrasena ='" + pass + "' WHERE dni ='"+dni+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag=cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarUsuario(string dni)
        {
            int flag = 0;
            con.Open();
            string query = "DELETE FROM Persona WHERE dni ='" + dni + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaUsuariosDG()
        {
            string query = "SELECT * FROM Persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }
    }
}
