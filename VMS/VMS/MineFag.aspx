﻿<%@ Page Title="Mine fag" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MineFag.aspx.cs" Inherits="VMS.MineFag" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mine fag</h1>
    <%--<div class="Row">
    </div>
   <div class="Row">
        <div class="col-md-4">
            <div class="divKnappBorder">
                <a href="fagside.aspx" style="text-decoration: none">
                    <div>
                        <asp:Label ID="FagkodeLbl" runat="server" Text="Label" ForeColor="Black" Font-Bold="true"></asp:Label><br />
                        <asp:Label ID="FagnavnLbl" runat="server" Text="Label" ForeColor="Black"></asp:Label><br />
                        <asp:Label ID="ForeleserLbl" runat="server" Text="Label" ForeColor="Black"></asp:Label><br />
                    </div>
                </a>
            </div>
        </div>
    </div>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <div id="testsomething" runat="server"></div>
        Alt over er bare for å vise hvordan ting var før, når det var hardkodet og for å vise hvordan man kan bruke metoder fra server siden til å skrive til html--%>
    <br />
    <asp:panel ID="panel1" runat="server"><asp:Literal ID="lit" runat="server"></asp:Literal></asp:panel>
</asp:Content>
