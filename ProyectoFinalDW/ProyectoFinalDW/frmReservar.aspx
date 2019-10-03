<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmReservar.aspx.cs" Inherits="ProyectoFinalDW.frmReservar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Mantenimiento a Usuarios</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 text-center modal-body">
            <asp:Label runat="server" Text="Reservar una habitacion"></asp:Label>
        </div>
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvReserva" runat="server" CssClass="table-hover table" EmptyDataText="No Existen habitaciones">
                <Columns>
                    <asp:BoundField HeaderText="Habitacion" DataField="habitacion" />
                    <asp:BoundField HeaderText="Fecha Inicio" DataField="habitacion" />
                    <asp:BoundField HeaderText="Fecha Fin" DataField="habitacion" />
                    <asp:BoundField HeaderText="Fecha Reserva"  DataField="habitacion"/>
                    <asp:BoundField HeaderText="Cama Supletoria" DataField="habitacion" />
                    <asp:BoundField HeaderText="Precio" DataField="habitacion" />
                    <asp:TemplateField HeaderText="Controles">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Editar"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-md-12 modal-body">
            <div class="col-md-4 col-md-offset-5">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" />
            </div>
        </div>
    </form>
</body>
</html>
