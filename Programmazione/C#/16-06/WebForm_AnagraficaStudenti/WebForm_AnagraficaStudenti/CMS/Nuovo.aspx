<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nuovo.aspx.cs" Inherits="WebForm_AnagraficaStudenti.CMS.Nuovo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Nuovo Studente</h1>
    <asp:DetailsView ID="dvNuovoStudente" runat="server" Height="50px" Width="90%" AutoGenerateRows="False" CellPadding="4" DataKeyNames="Matricola" DataSourceID="sdsNuovoStudente" DefaultMode="Insert" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="Matricola" HeaderText="Matricola" ReadOnly="True" SortExpression="Matricola" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Cognome" HeaderText="Cognome" SortExpression="Cognome" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Classe" HeaderText="Classe" SortExpression="Classe" />
            <asp:CommandField ShowInsertButton="True">
            <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
</asp:DetailsView>


<asp:SqlDataSource ID="sdsNuovoStudente" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [Studenti] WHERE [Matricola] = @Matricola" InsertCommand="INSERT INTO [Studenti] ([Matricola], [Nome], [Cognome], [Email], [Classe]) VALUES (@Matricola, @Nome, @Cognome, @Email, @Classe)" SelectCommand="SELECT * FROM [Studenti]" UpdateCommand="UPDATE [Studenti] SET [Nome] = @Nome, [Cognome] = @Cognome, [Email] = @Email, [Classe] = @Classe WHERE [Matricola] = @Matricola">
    <DeleteParameters>
        <asp:Parameter Name="Matricola" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Matricola" Type="Int32" />
        <asp:Parameter Name="Nome" Type="String" />
        <asp:Parameter Name="Cognome" Type="String" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Classe" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Nome" Type="String" />
        <asp:Parameter Name="Cognome" Type="String" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Classe" Type="String" />
        <asp:Parameter Name="Matricola" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>


</asp:Content>
