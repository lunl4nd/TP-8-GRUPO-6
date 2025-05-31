using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
namespace Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private NegocioSucursal negocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                negocio = new NegocioSucursal();
                CargarProvincias();
            }
        }

        private void CargarProvincias()
        {
            ddlProvincia.DataSource = negocio.getTablaProvincias();
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("--Selecione una provincia--", "0"));
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            negocio = new NegocioSucursal();
            negocio.agregarSucursal(txtNombre.Text, txtDescripcion.Text, txtDireccion.Text, ddlProvincia.SelectedIndex);
            lblExito.Visible = true;

            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlProvincia.SelectedIndex = 0;
            txtDescripcion.Text = string.Empty;


        }
    }
}