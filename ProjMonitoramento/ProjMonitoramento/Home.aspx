<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjMonitoramento.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbldescricao" runat="server" Text="Descrição : "></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" Width="456px"></asp:TextBox>
        <p>
            <asp:Label ID="lblqtde" runat="server" Text="Quantidade de cameras :"></asp:Label>
            <asp:TextBox ID="txtQtde" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblNomeCliente" runat="server" Text="Nome Cliente:"></asp:Label>
        <asp:TextBox ID="txtNomeCliente" runat="server" Width="437px"></asp:TextBox>
        <p>
            <asp:Label ID="lblValor" runat="server" Text="Valor:"></asp:Label>
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        </p>
        <p>
            Fidelidade
        </p>
        <asp:RadioButton ID="rbtnSim" runat="server" Text="Sim" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbtnNao" runat="server" Text="Não" />
        <p>
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Style="margin-bottom: 0px" Text="Salvar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click" />
        </p>
        <p>
            <asp:GridView ID="gvMonitoramento" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Id" SortExpression="id">
                        <ItemTemplate>
                            <asp:Label ID="lblId" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Descricao" SortExpression="descricao">
                        <ItemTemplate>
                            <asp:Label ID="lbldescr" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cliente" SortExpression="nomeCliente">
                        <ItemTemplate>
                            <asp:Label ID="lblCliente" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantidade Cameras" SortExpression="qtdeCamera">
                        <ItemTemplate>
                            <asp:Label ID="lblqtde" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="valor" SortExpression="valorPacote">
                        <ItemTemplate>
                            <asp:Label ID="lblValor" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="fidelidade" SortExpression="isFidelidade">
                        <ItemTemplate>
                            <asp:Label ID="lblfid" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </p>
        <p>
            &nbsp;
        </p>

    </form>
</body>
</html>
