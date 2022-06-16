<%@ Page Title="Password cambiata" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResetPasswordConfirmation.aspx.cs" Inherits="WebForm_AccessoDB.Account.ResetPasswordConfirmation" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <div>
        <p>La password è stata cambiata. Fare clic <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Account/Login">qui</asp:HyperLink> per accedere </p>
    </div>
</asp:Content>
