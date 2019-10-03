<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBebidas.aspx.cs" Inherits="ProyectoFinalDW.frmBebidas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento Bebidas</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 table-bordered">
            <div class="col-md-12 text-center modal-body">
                <asp:Label runat="server" Text="Ingreso de nueva bebida"></asp:Label>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre Bebida: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtNombreBebida" CssClass="form-control" ></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError1"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Marca: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtMarca"  CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Precio: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TxtPrecio" CssClass="form-control"></asp:TextBox>
                    <asp:Label Text="*" ForeColor="Red" Visible ="false" runat="server" ID="lblError2"></asp:Label>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Fecha Caducidad: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtFechaCaducidad" TextMode="Date" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-12 modal-body">
            <div class="col-md-3 col-md-offset-4">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
            </div>
            <div class="col-md-3">
                 <asp:Button runat="server" ID="btnRegresar" Text="Regresar" CssClass="btn btn-danger" OnClick="btnRegresar_Click" />
            </div>
        </div>
        <div class="alert alert-success col-md-12" runat="server" id="dvCorrecto" visible="false">
             Bebida ingresada correctamente!
        </div>
        <div class="alert alert-danger col-md-12" runat="server" id="dvError" visible="false">
            <strong>Error:</strong><asp:Label runat="server" ID="lblError"></asp:Label>
        </div>
        <div class="col-md-12">
            <asp:GridView  runat="server" EmptyDataText="No Hay Habitaciones ingresadas" AutoGenerateColumns="false" ID="gvBebidas" CssClass="table table-bordered">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="marca" HeaderText="Marca" />
                    <asp:BoundField DataField="FECHA_VENCIMIENTO" HeaderText="fecha de vencimiento" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
