using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        private NegocioSucursal negocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarSucursalesTodas();
            }
        }

        private void CargarSucursalesTodas()
        {
            negocio = new NegocioSucursal();
            gvSucursales.DataSource = negocio.getTablaSucursales();
            gvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            negocio = new NegocioSucursal();
            if(txtFiltrar.Text == string.Empty)
            {
                CargarSucursalesTodas();
                return;
            }
            gvSucursales.DataSource = negocio.getTableSucursalesFiltrada(int.Parse(txtFiltrar.Text));
            gvSucursales.DataBind();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarSucursalesTodas();
        }
    }
}