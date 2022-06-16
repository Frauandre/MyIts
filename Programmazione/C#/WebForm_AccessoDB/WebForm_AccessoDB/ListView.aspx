<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="WebForm_AccessoDB.ListView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ListView</h1>
    <asp:ListView ID="lvStudenti" runat="server" DataKeyNames="Matricola" DataSourceID="sdsStudenti">
        <AlternatingItemTemplate>
            <li style="background-color: #FFF8DC;">Matricola:
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
            </li>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <li style="background-color: #008A8C;color: #FFFFFF;">Matricola:
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
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Aggiorna" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Annulla" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            Non è stato restituito alcun dato.
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <li style="">Matricola:
                <asp:TextBox ID="MatricolaTextBox" runat="server" Text='<%# Bind("Matricola") %>' />
                <br />Nome:
                <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
                <br />Cognome:
                <asp:TextBox ID="CognomeTextBox" runat="server" Text='<%# Bind("Cognome") %>' />
                <br />Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />Classe:
                <asp:TextBox ID="ClasseTextBox" runat="server" Text='<%# Bind("Classe") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Inserisci" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancella" />
            </li>
        </InsertItemTemplate>
        <ItemSeparatorTemplate>
<br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
            <li style="background-color: #DCDCDC;color: #000000;">Matricola:
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
            </li>
        </ItemTemplate>
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">Matricola:
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
            </li>
        </SelectedItemTemplate>
</asp:ListView>
    <asp:SqlDataSource ID="sdsStudenti" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Studenti]"></asp:SqlDataSource>

</asp:Content>
