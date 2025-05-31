<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            width: 238px;
        }
        .auto-style9 {
            width: 218px;
        }
        .auto-style10 {
            width: 266px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="5">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style9">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                                </td>
                                <td class="auto-style10">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                                </td>
                                <td>
                        <asp:HyperLink ID="HyperLink3" runat="server">Eliminar Sucursal</asp:HyperLink>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label ID="LabelListado" runat="server" Font-Bold="True" Font-Size="18pt" Text="Listado de sucursales"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="5"></td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="lblBusqueda" runat="server" Text="Busqueda ingrese el Id sucursal:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFiltrar" runat="server" Width="92px"></asp:TextBox>
                        <asp:CompareValidator ID="cvId" runat="server" ErrorMessage="Ingrese un numero." ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtFiltrar"></asp:CompareValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
                    </td>
                    <td>
                        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar Todos" OnClick="btnMostrar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:GridView ID="gvSucursales" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
