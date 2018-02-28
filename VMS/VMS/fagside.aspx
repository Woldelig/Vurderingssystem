<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="fagside.aspx.cs" Inherits="VMS.Fagside" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <asp:Label ID="fagkodeLbl" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="fagkode"></asp:Label>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="fagnavnLbl" runat="server" Text="fagnavn: eks Markedsføringsledelse"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="pensumLbl" runat="server" Text="Pensum:"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="pensumRatingLbl" runat="server"></asp:Label></div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="foreleserLbl" runat="server" Text="Foreleser: Vetle Haugan"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="kvalitetLbl" runat="server" Text="Forelesningskvalitet:"></asp:Label></div>
        <div class="col-md-4">[RATING]</div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="studieretningLbl" runat="server" Text="Studie: It og informasjonssystemer"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="vasnkelighetsgradLbl" runat="server" Text="Vanskelighetsgrad:"></asp:Label></div>
        <div class="col-md-4">[RATING]</div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="forkursLbl" runat="server" Text="Forkurs: Prg1000"></asp:Label></div>
        <div class="col-md-4">[KODE]</div>
        <div class="col-md-4">[RATING]</div>
    </div>
        <asp:Chart ID="diagram" runat="server" Height="400px" Width="400px">
            <Series>
                <asp:Series ChartType="Pie" Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
</asp:Content>
