<%@ Page Title="Studielinje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LinjeSide.aspx.cs" Inherits="VMS.LinjeSide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="studielinjeLbl" runat="server" Font-Bold="True" Font-Size="XX-Large" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <div class="Row">
        <table class="table table-hover">
            <thead>
                <tr>
                    <th>Fagnavn</th>
                    <th>Fagkode</th>
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
