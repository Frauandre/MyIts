<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormView.aspx.cs" Inherits="WebForm_AccessoDB.FormView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>FormView</h1>
    <asp:FormView ID="fvStudenti" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="Matricola" DataSourceID="sdsStudenti" ForeColor="Black">
        <EditItemTemplate>
            Matricola:
            <asp:Label ID="MatricolaLabel1" runat="server" Text='<%# Eval("Matricola") %>' />
            <br />
            Nome:
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            Cognome:
            <asp:TextBox ID="CognomeTextBox" runat="server" Text='<%# Bind("Cognome") %>' />
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Classe:
            <asp:TextBox ID="ClasseTextBox" runat="server" Text='<%# Bind("Classe") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Aggiorna" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Annulla" />
        </EditItemTemplate>
        <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <InsertItemTemplate>
            Matricola:
            <asp:TextBox ID="MatricolaTextBox" runat="server" Text='<%# Bind("Matricola") %>' />
            <br />
            Nome:
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            Cognome:
            <asp:TextBox ID="CognomeTextBox" runat="server" Text='<%# Bind("Cognome") %>' />
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Classe:
            <asp:TextBox ID="ClasseTextBox" runat="server" Text='<%# Bind("Classe") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Inserisci" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Annulla" />
        </InsertItemTemplate>
        <ItemTemplate>
            Matricola:
            <asp:Label ID="MatricolaLabel" runat="server" Text='<%# Eval("Matricola") %>' />
            <br />
            Nome:
            <asp:Label ID="NomeLabel" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            Cognome:
            <asp:Label ID="CognomeLabel" runat="server" Text='<%# Bind("Cognome") %>' />
            <br />
            Email:
            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Classe:
            <asp:Label ID="ClasseLabel" runat="server" Text='<%# Bind("Classe") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Modifica" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Elimina" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Nuovo" />
        </ItemTemplate>
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
</asp:FormView>
    <asp:SqlDataSource ID="sdsStudenti" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [Studenti] WHERE [Matricola] = @Matricola" InsertCommand="INSERT INTO [Studenti] ([Matricola], [Nome], [Cognome], [Email], [Classe]) VALUES (@Matricola, @Nome, @Cognome, @Email, @Classe)" SelectCommand="SELECT * FROM [Studenti]" UpdateCommand="UPDATE [Studenti] SET [Nome] = @Nome, [Cognome] = @Cognome, [Email] = @Email, [Classe] = @Classe WHERE [Matricola] = @Matricola">
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
