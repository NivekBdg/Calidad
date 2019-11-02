<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="ProyectoFinalDW.frmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento a Usuarios prueba</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 text-center modal-body bg-primary">
            <asp:ImageButton runat="server" ImageUrl="Imagenes/back.png" Width="50px" Height="50px" ID="btnBack" OnClick="btnBack_Click"/><h1><asp:Label runat="server" Text="Mantenimiento a Usuarios"></asp:Label></h1>
        </div>
        <div class="col-md-12 table-bordered">
            <div class="col-md-12 text-center modal-body">
                <asp:Label runat="server" Text="Ingreso de nuevo Usuario"></asp:Label>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre de Usuario: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtNombreUsuario" CssClass="form-control" ></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError1"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Contraseña: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TxtPass" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError2"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Email: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError3"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Apellidos: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtApellidos" CssClass="form-control"></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError4"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Dirección: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Identificación: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError5"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Teléfono: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtTelefono" TextMode="Number" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-12 modal-body">
            <div class="col-md-4 col-md-offset-5">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
            </div>
        </div>
        <div class="alert alert-success col-md-12" runat="server" id="dvCorrecto" visible="false">
            <strong>Error:</strong> Usuario Ingresado correctamente 
        </div>
        <div class="alert alert-danger col-md-12" runat="server" id="dvError" visible="false">
            <strong>Error:</strong><asp:Label runat="server" ID="lblError"></asp:Label>
        </div>
    </form>
</body>
</html>
