<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="velkomstside.aspx.cs" Inherits="VMS.velkomstside" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Velkommen til vurderingssystemet!</h1>
        <p>Trykk på "Logg inn" for å logge inn med en student-ID eller trykk "Fortsett" for å logge inn uten student-ID</p>
        
        <br />
        <asp:Button class="btn btn-success btn-lg" ID="LoginBtn" runat="server" Text="Logg inn" OnClick="LoginBtn_Click" />
        <asp:Button class="btn btn-primary btn-lg" ID="continue" runat="server" Text="Fortsett" OnClick="continue_Click" />
    </div>
</asp:Content>
