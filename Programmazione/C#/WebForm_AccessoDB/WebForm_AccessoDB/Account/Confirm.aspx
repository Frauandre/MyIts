<%@ Page Title="Conferma account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="WebForm_AccessoDB.Account.Confirm" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successPanel" ViewStateMode="Disabled" Visible="true">
            <p>
                Grazie per aver confermato l'account. Fare clic <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Account/Login">qui</asp:HyperLink>  per accedere             
            </p>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="errorPanel" ViewStateMode="Disabled" Visible="false">
            <p class="text-danger">
                Si è verificato un errore.
            </p>
        </asp:PlaceHolder>
    </div>
</asp:Content>
