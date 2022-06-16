<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_AnagraficaStudenti.CMS.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>CMS - Area Riservata</h1>



   
<asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>

    </AnonymousTemplate>
    <LoggedInTemplate>

    </LoggedInTemplate>
    <RoleGroups>
        <asp:RoleGroup Roles="Administrators">
            <ContentTemplate>
                <a href="Nuovo.aspx">Nuovo Studente</a>
            </ContentTemplate>
        </asp:RoleGroup>
    </RoleGroups>
</asp:LoginView>


</asp:Content>

