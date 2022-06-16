<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Studenti.aspx.cs" Inherits="WebForm_AnagraficaStudenti.Studenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Elenco studenti</h1>

    <pre>
    usare una GridView e visualizzare solo
    nome, cognome e classe
    consentire l'ordinamento su classe
    formattare la griglia con il template professionale
    </pre>

    <div>        
    <asp:Label ID="lblCerca" runat="server" Text="Seleziona una classe"></asp:Label>
    <asp:DropDownList ID="ddlCerca" runat="server" DataSourceID="sdsClassi" DataTextField="Classe" DataValueField="Classe" AppendDataBoundItems="True">
        <asp:ListItem>tutto</asp:ListItem>
    </asp:DropDownList>        
    <asp:Button ID="btnCerca" runat="server" Text="Cerca" />
</div>
    <br /><br />

    <asp:GridView ID="gvStudenti" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="sdsStudenti" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="60%" DataKeyNames="Matricola">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Matricola" HeaderText="Matricola" SortExpression="Matricola" ReadOnly="True" Visible="False" />
            <asp:BoundField DataField="Classe" HeaderText="Classe" SortExpression="Classe" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Cognome" HeaderText="Cognome" SortExpression="Cognome" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="" Text="Dettaglio" PostBackUrl='<%# Eval("Matricola", "~/DettaglioStudente.aspx?matricola={0}") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
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


    <asp:SqlDataSource ID="sdsClassi" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT DISTINCT [Classe] FROM [Studenti] ORDER BY [Classe]"></asp:SqlDataSource>

<asp:SqlDataSource ID="sdsStudenti" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
    SelectCommand="SELECT Matricola, [Classe], [Nome], [Cognome] FROM [Studenti]"></asp:SqlDataSource>




</asp:Content>
