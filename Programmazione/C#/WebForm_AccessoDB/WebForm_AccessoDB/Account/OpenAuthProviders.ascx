<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="WebForm_AccessoDB.Account.OpenAuthProviders" %>

<div id="socialLoginList">
    <h4>Utilizzare un altro servizio per eseguire l'accesso.</h4>
    <hr />
    <asp:ListView runat="server" ID="providerDetails" ItemType="System.String"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <p>
                <button type="submit" class="btn btn-default" name="provider" value="<%#: Item %>"
                    title="Accedi con l'account <%#: Item %> personale.">
                    <%#: Item %>
                </button>
            </p>
        </ItemTemplate>
        <EmptyDataTemplate>
            <div>
                <p>Non sono configurati servizi di autenticazione esterni. Vedere <a href="https://go.microsoft.com/fwlink/?LinkId=252803">questo articolo</a> per informazioni su come configurare l'applicazione ASP.NET per il supporto dell'accesso tramite servizi esterni.</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</div>
