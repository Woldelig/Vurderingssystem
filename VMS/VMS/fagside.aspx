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
        <div class="col-md-2">
            <input type="range" id="pensumRatingStjerne" ClientIDMode="static" min="0" max="5" value="0" step="0.1" runat="server">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#pensumRatingStjerne"></div>
        </div>
        <div class="col-md-2"><asp:Label ID="pensumRatingLbl" runat="server"></asp:Label></div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="foreleserLbl" runat="server" Text="Foreleser: Vetle Haugan"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="kvalitetLbl" runat="server" Text="Forelesningskvalitet:"></asp:Label></div>
        <div class="col-md-2">
            <input type="range" runat="server" id="kvalitetRatingStjerne" min="0" max="5" value="0" step="0.1" ClientIDMode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#kvalitetRatingStjerne"></div>
        </div>
        <div class="col-md-2"><asp:Label ID="kvalitetRatingLbl" runat="server"></asp:Label></div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="studieretningLbl" runat="server" Text="Studie: It og informasjonssystemer"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="vasnkelighetsgradLbl" runat="server" Text="Vanskelighetsgrad:"></asp:Label></div>
        <div class="col-md-2">
            <input type="range" runat="server" id="vanskelighetsgradRatingStjerne" min="0" max="5" value="0" step="0.1" ClientIDMode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#vanskelighetsgradRatingStjerne"></div>
        </div>
        <div class="col-md-2"><asp:Label ID="vanskelighetsgradRatingLbl" runat="server"></asp:Label></div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="forkursLbl" runat="server" Text="Forkurs: Prg1000"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="spm4Lbl" runat="server" Text ="placeholder"></asp:Label></div>
        <div class="col-md-2">
            <input type="range" runat="server" id="spm4RatingStjerne" min="0" max="5" value="0" step="0.1" ClientIDMode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm4RatingStjerne"></div>
        </div>
        <div class="col-md-2"><asp:Label ID="spm4RatingLbl" runat="server"></asp:Label></div>
    </div>    
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4"><asp:Label ID="placeholder" runat="server" Text ="placeholder"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="spm5Lbl" runat="server" Text ="placeholder"></asp:Label></div>
        <div class="col-md-2">
            <input type="range" runat="server" id="spm5RatingStjerne" min="0" max="5" value="0" step="0.1" ClientIDMode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm5RatingStjerne"></div>
        </div>
        <div class="col-md-2"><asp:Label ID="spm5RatingLbl" runat="server"></asp:Label></div>
    </div>    
    <br />
    <br />
    <br />
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
