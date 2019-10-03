<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMenuPrincipal.aspx.cs" Inherits="ProyectoFinalDW.frmMenuPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Principal</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12">
            <div class="col-md-12 modal-body text-center bg-primary">
                <h1>Menú Principal</h1>
            </div>
            <div class="col-md-12">
                <div class="col-md-3 col-md-offset-3 modal-body table-bordered text-center" runat="server" id="dvReservarHabitacion">
                    Reservar una habitacion<br />
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/btn-reserva.png" Width="100px" Height="100px" ID="btnReserva" OnClick="btnReserva_Click"/>
                </div>
                <div class="col-md-3 modal-body table-bordered text-center" runat="server" id="dvAdminUsuarios">
                    Agregar Usuarios<br />
                    <asp:ImageButton runat="server" ImageUrl="Imagenes/add.png" Width="100px" Height="100px" ID="btnAgregarUsuario" OnClick="btnAgregarUsuario_Click"/>
                </div>
                <br />
                <div class="col-md-3 col-md-offset-3 modal-body table-bordered text-center" runat="server" id="dvBebidas">
                    Bebidas<br />
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/bebida2.png" Width="100px" Height="100px" ID="btnBebida" OnClick="btnBebida_Click"/>
                </div>
                <div class="col-md-3 modal-body table-bordered text-center" runat="server" id="dvAgregarHotel">
                    Agregar Hoteles<br />
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/hotel.png" Width="100px" Height="100px" ID="btnAgregarHotel" OnClick="btnAgregarHotel_Click"/>
                </div>
                <br />
                <div class="col-md-3 col-md-offset-3 modal-body table-bordered text-center" runat="server" id="dvAgregarHabitacion">
                    Agregar habitaciones<br />
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/icono-habitación.png" Width="100px" Height="100px" ID="btnHabitacion" OnClick="btnHabitacion_Click"/>
                </div>
                <div class="col-md-3 modal-body table-bordered text-center" runat="server" id="Div1">
                    Agregar Permisos a Usuarios<br />
                    <asp:ImageButton runat="server" ImageUrl="Imagenes/Iynque-Ios7-Style-Users.ico" Width="100px" Height="100px" ID="btnPermisos" OnClick="btnPermisos_Click"/>
                </div>
                <br />
                <div class="col-md-3 col-md-offset-3 modal-body table-bordered text-center" runat="server" id="dvSalir">
                    Salir<br />
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exit.png" Width="100px" Height="100px" ID="btnExit" OnClick="btnExit_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
