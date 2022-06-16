<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DettaglioStudente.aspx.cs" Inherits="WebForm_AnagraficaStudenti.DettaglioStudente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Dettaglio studente</h1>

    <pre>
    Creare una connessione al database per recuperare tutti i dati dello studente
    Utilizzare un oggetto di tipo DetailsView per formattare i dati
    Utilizzare la formattazione professionale

    Rendere disponibili le operazioni di modifica
        </pre>


<asp:DetailsView ID="dvDettaglioStudente" runat="server" Height="50px" Width="60%" CellPadding="4" DataSourceID="sdsDettaglioStudente" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
    <EditRowStyle BackColor="#999999" />
    <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
    <Fields>
        <asp:CommandField ShowEditButton="True">
        <ItemStyle HorizontalAlign="Center" />
        </asp:CommandField>
    </Fields>
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>

    <asp:SqlDataSource ID="sdsDettaglioStudente" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
        SelectCommand="SELECT * FROM [Studenti] WHERE ([Matricola] = @Matricola)" 
        UpdateCommand="UPDATE [Studenti] SET [Nome] = @Nome, [Cognome] = @Cognome, [Email] = @Email, [Classe] = @Classe WHERE [Matricola] = @Matricola">
       <SelectParameters>
           <asp:QueryStringParameter Name="Matricola" QueryStringField="matricola" Type="Int32" />
       </SelectParameters>
       <UpdateParameters>
            <asp:Parameter Name="Nome" Type="String" />
            <asp:Parameter Name="Cognome" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Classe" Type="String" />
            <asp:Parameter Name="Matricola" Type="Int32" />
        </UpdateParameters>

    </asp:SqlDataSource>



    



</asp:Content>
