<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MineFag.aspx.cs" Inherits="VMS.MineFag" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Row">
        <div class="col-md-4">
            <div class="divKnappBorder">
                <a href="fagside.aspx" style="text-decoration:none">
                    <div>
                        <asp:Label ID="FagkodeLbl" runat="server" Text="Label" Font-Bold="true"></asp:Label><br />
                        <asp:Label ID="FagnavnLbl" runat="server" Text="Label"></asp:Label><br />
                        <asp:Label ID="ForleserLbl" runat="server" Text="Label"></asp:Label><br />
                    </div>
                </a>
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
