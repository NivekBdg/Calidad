<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHabitacion.aspx.cs" Inherits="ProyectoFinalDW.frmHabitacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>Mantenimiento a Habitaciones</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 text-center modal-body">
            <asp:Label runat="server" Text="Mantenimiento a Habitaciones"></asp:Label>
        </div>
        <div class="col-md-12 table-bordered">
            <div class="col-md-12 text-center modal-body">
                <asp:Label runat="server" Text="Ingreso de nueva habitacion"></asp:Label>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Hotel: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlHoteles" CssClass="form-control">
                        <asp:ListItem Text="Hotel 1" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Hotel 2" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Categoria: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-control">
                        <asp:ListItem Text="Categoria 1" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Categoria 2" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Tipo: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlTipo" CssClass="form-control">
                        <asp:ListItem Text="Tipo 1" Value="1"></asp:ListItem>
                         <asp:ListItem Text="Tipo 2" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Codigo: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            
            
            <div class="col-md-12 modal-body">
                <div class="col-md-4 col-md-offset-5">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
        <div class="col-md-12">
            <asp:GridView ID="gvHabitaciones" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered" EmptyDataText="No Hay Habitaciones ingresadas" ></asp:GridView>
        </div>

    </form>
</body>
</html>
