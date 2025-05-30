using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos dato = new AccesoDatos();
        
        public DaoSucursal() 
        {
            
        }

        public DataTable GetTablaProvincias()
        {
            DataTable table = dato.ObtenerTabla("Provincia", "SELECT * FROM Provincia");
            return table;
        }

        public DataTable GetTablaSucursales()
        {
            DataTable table = dato.ObtenerTabla("Provincia", "SELECT * FROM Sucursal");
            return table;
        }

        public int EliminarSucursal(Sucursal reg)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, reg);
            return dato.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        public int AgregarSucursal(Sucursal reg)
        {

            reg.setIdSucursal(dato.ObtenerMaximo("SELECT max(Id_Sucursal) FROM Sucursal") + 1);
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, reg);
            return dato.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Sucursal reg)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            SqlParametros.Value = reg.getIdSucursal();
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal reg)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar);
            SqlParametros.Value = reg.getNombreSucursal();
            SqlParametros = Comando.Parameters.Add("@DescripcionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = reg.getDescripcion();
            SqlParametros = Comando.Parameters.Add("@Id_ProvinciaSucursal", SqlDbType.Int);
            SqlParametros.Value = reg.getIdProvincia();
            SqlParametros = Comando.Parameters.Add("@DireccionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = reg.getDireccion();
        }

        /*
        CREATE PROCEDURE[dbo].[spEliminarSucursal]
        (@Id_Sucursal INT)
        AS
        DELETE Sucursal WHERE Id_Sucursal = @Id_Sucursal
        RETURN
       
       CREATE PROCEDURE[dbo].[spAgregarSucursal]
        (
        @NombreSucursal VARCHAR(100)
        @DescripcionSucursal VARCHAR(100)
        @Id_ProvinciaSucursal INT
        @DireccionSucursal VARCHAR(100)
        )
        AS
        INSERT INTO Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) 
        VALUES(@NombreSucursal,@DescripcionSucursal,@Id_ProvinciaSucursal,@DireccionSucursal)
        RETURN
        */


    }
}
