using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int Id_Sucursal;
        private string nombreSucursal;
        private string DescripcionSucursal;
        private string direccion;
        private int Id_ProvinciaSucursal;

        public Sucursal()
        {

        }

        public int getIdSucursal()
        {
            return Id_Sucursal;
        }

        public void setIdSucursal(int idSucursal)
        {
            Id_Sucursal = idSucursal;
        }

        public string getNombreSucursal()
        {
            return nombreSucursal;
        }

        public void setNombreSucursal(string nombre)
        {
            nombreSucursal = nombre;
        }

        public string getDescripcion()
        {
            return DescripcionSucursal;
        }

        public void setDescripcion(string descripcion)
        {
            DescripcionSucursal = descripcion;
        }

        public int getIdProvincia()
        {
            return Id_ProvinciaSucursal;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public void setDireccion(string dire)
        {
            direccion = dire;
        }

        public void setIdProvincia(int idProvincia)
        {
            Id_ProvinciaSucursal = idProvincia;
        }
    }
}
