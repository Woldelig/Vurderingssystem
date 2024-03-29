﻿<%@ Page Title="Fagside" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fagside.aspx.cs" Inherits="VMS.Fagside" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="fagkodeLbl" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="fagkode"></asp:Label>
    <br />
    <br />
    <br />
    <!-- Koden under brukes for å samle inn svaret fra brukerne. De skal svare ved hjelp av et stjernesystem.
        Brukerne skal kunne svare fra 1 til 5 stjerner, og det skal ikke være lov til å svare blankt. Denne sjekken er ikke implementert enda.
        Det brukes et inputfelt for å hente inn verdien. Vi bruker et eksternt rammeverk som heter RateIt som gjør det enkelt for oss tilpasse utsenet slik vi vil ha det.
     -->
    <div class="Row">
        <div class="col-md-4">
            <asp:Label ID="fagnavnLbl" runat="server" Text="fagnavn: eks Markedsføringsledelse"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="pensumLbl" runat="server" Text="Pensum:"></asp:Label>
        </div>
        <div class="col-md-2" id="spm1Div" runat="server">
            <input type="range" id="spm1RatingStjerne" clientidmode="static" min="0" max="5" value="0" step="0.1" runat="server">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm1RatingStjerne"></div>
        </div>
        <div class="col-md-2">
            <asp:Label ID="spm1RatingLbl" runat="server"></asp:Label>
        </div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4">
            <asp:Label ID="foreleserLbl" runat="server" Text="Foreleser: Vetle Haugan"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="kvalitetLbl" runat="server" Text="Forelesningskvalitet:"></asp:Label>
        </div>
        <div class="col-md-2" id="spm2Div" runat="server">
            <input type="range" runat="server" id="spm2RatingStjerne" min="0" max="5" value="0" step="0.1" clientidmode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm2RatingStjerne"></div>
        </div>
        <div class="col-md-2">
            <asp:Label ID="spm2RatingLbl" runat="server"></asp:Label>
        </div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4">
            <asp:Label ID="studieretningLbl" runat="server" Text="Studie: It og informasjonssystemer"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="vanskelighetsgradLbl" runat="server" Text="Vanskelighetsgrad:"></asp:Label>
        </div>
        <div class="col-md-2" id="spm3Div" runat="server">
            <input type="range" runat="server" id="spm3RatingStjerne" min="0" max="5" value="0" step="0.1" clientidmode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm3RatingStjerne"></div>
        </div>
        <div class="col-md-2">
            <asp:Label ID="spm3RatingLbl" runat="server"></asp:Label>
        </div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4">
            <asp:Label ID="fakultetLbl" runat="server" Text="Fakultet: Handelshøyskolen"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="pensumFormidlingLbl" runat="server" Text="Pensumformidling:"></asp:Label>
        </div>
        <div class="col-md-2" id="spm4Div" runat="server">
            <input type="range" runat="server" id="spm4RatingStjerne" min="0" max="5" value="0" step="0.1" clientidmode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm4RatingStjerne"></div>
        </div>
        <div class="col-md-2">
            <asp:Label ID="spm4RatingLbl" runat="server"></asp:Label>
        </div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-4">
            <asp:Label ID="forkursLbl" runat="server" Text="Forkurs: Prg1000"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="fagRelevantLbl" runat="server" Text="Om faget er relevant for linjen:"></asp:Label>
        </div>
        <div class="col-md-2" id="spm5Div" runat="server">
            <input type="range" runat="server" id="spm5RatingStjerne" min="0" max="5" value="0" step="0.1" clientidmode="static">
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" data-rateit-readonly="true" style="font-size: 30px" data-rateit-backingfld="#spm5RatingStjerne"></div>
        </div>
        <div class="col-md-2">
            <asp:Label ID="spm5RatingLbl" runat="server"></asp:Label>
        </div>
    </div>
    <br />
    <br />
    <br />
    <asp:Chart ID="diagram" runat="server" Height="500px" Width="500px">
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
