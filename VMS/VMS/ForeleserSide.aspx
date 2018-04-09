<%@ Page Title="Foreleser" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForeleserSide.aspx.cs" Inherits="VMS.ForeleserSide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="foreleserLbl" runat="server" Font-Bold="True" Font-Size="XX-Large" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <div class="Row">
        <table class="table table-hover">
            <thead>
                <tr>
                    <th>Fagkode</th>
                    <th>Fagnavn</th>
                    <th>Studielinje</th>
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
