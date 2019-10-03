<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdminUsuarios.aspx.cs" Inherits="ProyectoFinalDW.frmAdminUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asignacion de Rol</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <div class="col-md-12 text-center modal-body bg-primary">
            <asp:ImageButton runat="server" ImageUrl="Imagenes/back.png" Width="50px" Height="50px" ID="btnBack" OnClick="btnBack_Click"/><h1><asp:Label runat="server" Text="Asignar Roles a Usuarios"></asp:Label></h1>
        </div>
        <div class="col-md-12 table-bordered">
            <div class="col-md-12 text-center modal-body">
                <asp:Label runat="server" Text="Seleccione Usuarios: "></asp:Label>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre de Usuario: "></asp:Label>
                </div>
                <div class="col-md-3">
                    
                            <asp:DropDownList runat="server" ID="ddlUsuario" CssClass="form-control" OnLoad="ddlUsuario_Load" AutoPostBack="false" ></asp:DropDownList>
                        
                    
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Contraseña: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlRol" TextMode="Password" CssClass="form-control" OnLoad="ddlRol_Load" AutoPostBack="false"></asp:DropDownList>
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
        </div>
    </form>
</body>
</html>
