using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace CapaDato
{
    public class D_Clientes
    {
        SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        SqlCommand comando;
        public DataTable D_Listado()
        {
            SqlCommand cmd = new SqlCommand("Listarcliente", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Guardar(int idc, string nombre, string apellido, int idprestamo)
        {
            Cn.Open();
            string lineaComando = $"insert into clientes values ({idc},'{nombre}','{apellido}',{idprestamo})";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            Cn.Close();
        }

        public DataTable buscar(int idc)
        {
            Cn.Open();
            string lineaComando = $" select * from clientes where idc = {idc}";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();

            da.Fill(dt);
            Cn.Close();
            return dt;

        }

        public void Eliminar(int idc)
        {
            Cn.Open();
            string lineaComando = $"Delete from clientes where idc = {idc}";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            Cn.Close();

        }

        public void Update (int idc, string nombre, string apellido, int idprestamo)
        {
            Cn.Open();
            string lineaComando = $"Update clientes set nombre='{nombre}', apellido='{apellido}', idprestamo={idprestamo} where idc = {idc}";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            Cn.Close();
        }

        public DataTable D2_Listado()
        {
            SqlCommand cmd = new SqlCommand("Listarprestamos", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void GuardarPrestamo(string nombre, string apellido, int monto,int cuota, int tiempo , DateTime fecha,int interes, int monto_total)
        {
            Cn.Open();
            string lineaComando = $"insert into prestamos values ('{nombre}','{apellido}',{monto},{cuota},{tiempo},'{fecha}',{interes},{monto_total})";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            Cn.Close();
        }
        
        public void UpdatePrestamo(int idprestamo,string nombre, string apellido, int monto, int cuota, int tiempo, DateTime fecha, int interes, int monto_total)
        {
            Cn.Open();
            string lineaComando = $"Update prestamos set nombre= '{nombre}', apellido='{apellido}', monto={monto}, cuota= {cuota}, tiempo={tiempo}, fecha='{fecha}',interes={interes}, monto_total={monto_total} where idprestamo= {idprestamo}" ;
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            Cn.Close();
        }

        public DataTable BuscarPrestamo(int idprestamo)
        {
            Cn.Open();
            string lineaComando = $" select * from prestamos where idprestamo = {idprestamo}";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();

            da.Fill(dt);
            Cn.Close();
            return dt;

        }

        public void EliminarPrestamo(int idprestamo)
        {
            Cn.Open();
            string lineaComando = $"Delete from prestamos where idprestamo = {idprestamo}";
            comando = new SqlCommand(lineaComando, Cn);
            comando.ExecuteNonQuery();
            Cn.Close();

        }
    }

}
