using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using CapaDato;
using System.Data;


 namespace Capa_Negocio
   
{
    public class N_Clientes
    {
        D_Clientes objdato = new D_Clientes();

       
        public DataTable N_listado()
        {
            return objdato.D_Listado();
        }

       public void guardar(int idc , string nombre, string apellido, int idprestamo)
        {
            objdato.Guardar(idc, nombre, apellido, idprestamo);
        }

        
        public DataTable buscar(int idc)
        {
           return objdato.buscar(idc);
        }
      public void Eliminar(int idc)
        {
            objdato.Eliminar(idc);
        }

        public void Update (int idc,string nombre, string apellido,int idprestamo)
        {
            objdato.Update(idc,nombre,apellido,idprestamo);
        }
        
        public void GuardarPrestamos(string nombre, string apellido, int monto, int cuota, int tiempo, DateTime fecha,int interes, int monto_total)
        {
            objdato.GuardarPrestamo(nombre,apellido,monto,cuota,tiempo,fecha,interes,monto_total);
        }
        public DataTable D2_Listado()
        {
            return objdato.D2_Listado();
        }

        public void UpdatePrestamo(int idprestamo,string nombre, string apellido, int monto, int cuota, int tiempo, DateTime fecha, int interes, int monto_total)
        {
            objdato.UpdatePrestamo( idprestamo,nombre, apellido,monto,cuota,tiempo,fecha,interes,monto_total);
        }
        public DataTable BuscarPrestamo(int idprestamo)
        {
            return objdato.BuscarPrestamo(idprestamo);
        }

        public void EliminarPrestamo(int idprestamo)
        {
            objdato.EliminarPrestamo(idprestamo);
        }
    }
}
