<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinalDW.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login </title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="modal-body">
        <div class="col-md-5 table-bordered modal-body col-md-offset-4 media-heading">
            <div class="col-md-12 modal-header bg-success">
                <h3><asp:Label runat="server" Text="Acceso al sistema" CssClass="label"></asp:Label></h3>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-10 modal-body">
                    <span class="glyphicon glyphicon-user"></span>
                    <asp:TextBox runat="server" ID="txtUser" placeholder="Ingrese usuario" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-10 modal-body">
                    <span class="glyphicon glyphicon-lock"></span>
                    <asp:TextBox runat="server" ID="txtPass" placeholder="Ingrese Contraseña" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-footer">
                <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btn btn-success" OnClick="btnLogin_Click" />
            </div>
        </div>
        <div class="alert alert-danger col-md-12" runat="server" id="dvError" visible="false">
            <strong>Error:</strong> Usuario/Contraseña Incorrecto. <asp:Label runat="server" ID="lblError"></asp:Label>
        </div>
    </form>
</body>
</html>
