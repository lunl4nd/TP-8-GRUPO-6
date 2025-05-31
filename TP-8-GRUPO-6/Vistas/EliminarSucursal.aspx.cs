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
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void delbtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(deletebox.Text.Trim(), out id))
            {
                NegocioSucursal negocio = new NegocioSucursal();
                bool exito = negocio.eliminarSucursal(id);

                if (exito)
                {
                    lblMensaje.Text = "Sucursal eliminada correctamente.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMensaje.Text = "No se encontró ninguna sucursal con ese ID.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }

                deletebox.Text = "";
            }
            else
            {
                lblMensaje.Text = "ID inválido.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}