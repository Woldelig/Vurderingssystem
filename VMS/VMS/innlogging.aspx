<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="innlogging.aspx.cs" Inherits="VMS.innlogging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="loginID">
        <br />
        <asp:Label ID="Melding" runat="server" Text="Logg inn med Student-ID"></asp:Label>
        
        <br />
        <asp:TextBox ID="StudentID" runat="server" Width="145px"></asp:TextBox> 
        <asp:Button ID="Login" runat="server" Text="Logg inn" OnClick="Login_Click" />
    </div>
    <asp:Label ID="Feilmelding" runat="server" Text=""></asp:Label>
</asp:Content>
