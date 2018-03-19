<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VMS._Default" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Vurderingssystem for Høgskolen i Sørøst-Norge</h2>
        <br />
        <asp:Label ID="StudIDLabel" runat="server" Text="StudentID"></asp:Label>
    </div>

    <div class="row" id="minefagDiv" runat="server">
        <div class="col-md-6">
            <h2>Mine fag</h2>
            <p>Her kan du se en liste over fag du tar eller har tatt.
            </p>
            <p>
                <a class="btn btn-info" href="MineFag.aspx">Mine fag&raquo;</a>
            </p>
        </div>
        <div class="col-md-6" id="minevurderingerDiv" runat="server">
            <h2>Mine vurderinger</h2>
            <p>
                Her kan du se en liste over vurderinger du kan ta, og du ser vurderinger du allerede har tatt.
            </p>
            <p>
                <a class="btn btn-info" href="MineVurderinger.aspx">Mine vurderinger &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
