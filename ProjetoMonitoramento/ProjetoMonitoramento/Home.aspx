<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjetoMonitoramento.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/Bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="clearfix text-center">
            <div class="clearfix">
                <asp:Label ID="lblNomeCliente" runat="server" Text="Nome Cliente:"></asp:Label><br />
                <asp:TextBox ID="txtNomeCliente" runat="server" Width="500px"></asp:TextBox>
            </div>
            <div class="clearfix">
                <asp:Label ID="lbldescricao" runat="server" Text="Descrição : "></asp:Label><br />
                <asp:TextBox ID="txtDescricao" runat="server" Width="500px"></asp:TextBox>

            </div>
            <div class="clearfix">
                <asp:Label ID="lblqtde" runat="server" Text="Quantidade de cameras :"></asp:Label><br />
                <asp:TextBox ID="txtQtde" runat="server"></asp:TextBox>
            </div>
            <div class="clearfix">
                <asp:Label ID="lblValor" runat="server" Text="Valor:"></asp:Label><br />
                <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            </div>
            <div class="clearfix">
                <asp:Label ID="lblfidelidade" runat="server" Text="Fidelidade"></asp:Label><br />
                <asp:RadioButton ID="rbtnSim" runat="server" Text="Sim" />
                <asp:RadioButton ID="rbtnNao" runat="server" Text="Não" />
            </div>

            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Style="margin-bottom: 0px" Text="Salvar" class="btn btn-primary" />
            </div>
            <%--<asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click" class="btn btn-primary" />--%>
            <div class="clearfix text-center">
            <asp:GridView ID="gvMonitoramento" runat="server" AutoGenerateColumns="False" DataSourceID="sdsmonitoramento" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" >
                <Columns>
                    <asp:TemplateField HeaderText="Monitoramento" SortExpression="id" >
                        <ItemTemplate>
                            <asp:Label ID="lblId" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Descricao" SortExpression="descricao">
                        <ItemTemplate>
                            <asp:Label ID="lbldescr" runat="server" Text='<%# Eval("descricao") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cliente" SortExpression="nomeCliente">
                        <ItemTemplate>
                            <asp:Label ID="lblCliente" runat="server" Text='<%# Bind("nomeCliente") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantidade Cameras" SortExpression="qtdeCamera">
                        <ItemTemplate>
                            <asp:Label ID="lblqtde" runat="server" Text='<%# Bind("qtdeCamera") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Pacote" SortExpression="pacote">
                        <ItemTemplate>
                            <asp:Label ID="lblfid" runat="server" Text='<%# Bind("pacote") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="valor" SortExpression="valorPacote">
                        <ItemTemplate>
                            <asp:Label ID="lblValor" runat="server" Text='<%# Bind("ValorPacote") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="fidelidade" SortExpression="isFidelidade">
                        <ItemTemplate>
                            <asp:Label ID="lblfid" runat="server" Text='<%# Bind("isFidelidade") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />

            </asp:GridView>
                </div>
            <asp:SqlDataSource ID="sdsmonitoramento" runat="server" ConnectionString="<%$ ConnectionStrings:SQLSERVER %>" SelectCommand="procSelecionar" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        
    </form>

    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
