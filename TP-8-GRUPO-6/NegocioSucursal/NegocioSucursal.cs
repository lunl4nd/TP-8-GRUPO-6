using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;
using System.ComponentModel;

namespace Negocio
{
    public class NegocioSucursal
    {
        public DataTable getTablaSucursales()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.GetTablaSucursales();
        }

        public int eliminarSucursal(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal obj = new Sucursal();
            obj.setIdSucursal(id);
            int op = dao.EliminarSucursal(obj);
            return op;
        }

        public bool agregarSucursal(string nombre, string descripcion, string direccion, int idProvincia)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal suc = new Sucursal();
            suc.setNombreSucursal(nombre);
            suc.setDescripcion(descripcion);
            suc.setDireccion(direccion);
            suc.setIdProvincia(idProvincia);

            int cantFilas = dao.AgregarSucursal(suc);
            return cantFilas == 1;
        }

        public DataTable getTablaProvincias()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.GetTablaProvincias();
        }

        public DataTable getTableSucursalesFiltrada(int idBuscada)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.GetTablaSucursalesFiltrada(idBuscada);
        }
    }
}
