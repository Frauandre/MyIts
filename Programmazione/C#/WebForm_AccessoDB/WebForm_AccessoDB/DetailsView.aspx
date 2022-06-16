<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsView.aspx.cs" Inherits="WebForm_AccessoDB.DetailsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Details View</h1>

    <asp:DetailsView ID="dvStudenti" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="Matricola" DataSourceID="sdsStudenti" Height="50px" Width="125px" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Aggiorna"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="Inserisci"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Modifica"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="New" Text="Nuovo"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Elimina" OnClientClick="return confirm('Eliminare i dati richiesti?');"></asp:LinkButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>

    <asp:SqlDataSource ID="sdsStudenti" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
        DeleteCommand="DELETE FROM [Studenti] WHERE [Matricola] = @Matricola" 
        InsertCommand="INSERT INTO [Studenti] ([Matricola], [Nome], [Cognome], [Email], [Classe]) VALUES (@Matricola, @Nome, @Cognome, @Email, @Classe)" 
        SelectCommand="SELECT * FROM [Studenti]" 
        UpdateCommand="UPDATE [Studenti] SET [Nome] = @Nome, [Cognome] = @Cognome, [Email] = @Email, [Classe] = @Classe WHERE [Matricola] = @Matricola">
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
