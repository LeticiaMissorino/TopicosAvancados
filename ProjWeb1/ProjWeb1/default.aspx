<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ProjWeb1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Nome:<asp:TextBox ID="txtNome" runat="server" Width="361px"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="lblCpf" runat="server" Text="CPF:"></asp:Label>
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <br />
        <p>
            RG:<asp:TextBox ID="txtRg" runat="server"></asp:TextBox>
        </p>
        Linguagem:<asp:TextBox ID="txtLing" runat="server"></asp:TextBox>
        <br />
        <br />
        Adjetivo:<asp:TextBox ID="txtAdj" runat="server"></asp:TextBox>
        <br />
        <br />
        Cidade:<asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <br />
        <br />
        Dia:<asp:TextBox ID="txtxDia" runat="server"></asp:TextBox>
        <br />
        <br />
        Ano:<asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
        <br />
        <br />
        Maior&nbsp; de idade:
        <asp:TextBox ID="txtMaior" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnImprimir" runat="server" OnClick="btnImprimir_Click" Text="Imprimir" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnListar" runat="server" OnClick="btnListar_Click" Text="Listar" />
        </p>
        <p>
            <asp:Label ID="lblDeclaracao" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
