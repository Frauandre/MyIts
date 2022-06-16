<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="WebForm_AccessoDB.DataList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Struttura DataList</h1>

    <asp:DataList ID="dlStudenti" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyField="Matricola" DataSourceID="sdsStudenti" GridLines="Horizontal" RepeatColumns="4">
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <ItemTemplate>
            Matricola:
            <asp:Label ID="MatricolaLabel" runat="server" Text='<%# Eval("Matricola") %>' />
            <br />
            Nome:
            <asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' />
            <br />
            Cognome:
            <asp:Label ID="CognomeLabel" runat="server" Text='<%# Eval("Cognome") %>' />
            <br />
            Email:
            <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
            <br />
            Classe:
            <asp:Label ID="ClasseLabel" runat="server" Text='<%# Eval("Classe") %>' />
            <br />
<br />
        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
</asp:DataList>



<asp:SqlDataSource ID="sdsStudenti" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Studenti]"></asp:SqlDataSource>



</asp:Content>
