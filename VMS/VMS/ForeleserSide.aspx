<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForeleserSide.aspx.cs" Inherits="VMS.ForeleserSide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="foreleserLbl" runat="server" Font-Bold="True" Font-Size="XX-Large" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4">
            <asp:Label ID="fakultetLbl" runat="server" Text="Fakultet: Handelshøyskolen"></asp:Label></div>
        <div class="col-md-4">
            <asp:Label ID="studieretningLbl" runat="server" Text="Linje: It og Informasjonssytemer"></asp:Label></div>
    </div>
    <div class="Row">
        <table Class="table table-hover">
            <thead>
                <tr>
                    <th>Fagkode</th>
                    <th>Fagnavn</th>
                    <th>Fakultet</th>
                </tr>
            </thead>
            <tbody id="tableBody" runat="server">
                
            </tbody>
        </table>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
