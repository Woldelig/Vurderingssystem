<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="fagside.aspx.cs" Inherits="VMS.fagside" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Label ID="fagkodeLbl" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="fagkode"></asp:Label>
    </p>
    <p>
        <asp:Label ID="fagnavnLbl" runat="server" Text="fagnavn: eks Markedsføringsledelse"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="foreleserLbl" runat="server" Text="Foreleser"></asp:Label>
    </p>
    <p>
        <asp:Label ID="studieLbl" runat="server" Text="studieretning"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="forkursLbl" runat="server" Text="forkurs"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series ChartType="Pie" Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </p>
</asp:Content>
