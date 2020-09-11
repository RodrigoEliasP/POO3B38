<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cdsform.aspx.cs" Inherits="POO3B38.Models.UI.cdsform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" aria-atomic="True">
        <asp:label ID="lblError" ForeColor="Red" Text=" " runat="server"></asp:label><br/>
        <p>Nome:</p>
        <asp:TextBox ID="txtNome" runat="server" ></asp:TextBox><br/>
        <p>Preço:</p>
        <asp:TextBox ID="txtPreco" runat="server" ></asp:TextBox><br/>
        <p>Lançamento</p>
        <asp:Calendar ID="calLancamento" runat="server"/><br/>
        <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click"/><br/>
        <asp:GridView ID="GridCds" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
