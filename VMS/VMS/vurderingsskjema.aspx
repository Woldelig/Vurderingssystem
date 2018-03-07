<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vurderingsskjema.aspx.cs" Inherits="VMS.vurderingsskjema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spmLbl" runat="server" Font-Size="X-Large" text="Spørsmål"></asp:Label></div>
        <div class="col-md-4"><asp:Label ID="placeholderLbl" runat="server" Font-Size="X-Large" Text="Vurdering"></asp:Label></div>
    </div>
    <br />
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm1Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm1rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm1rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm2Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm2rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm2rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm3Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm3rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm3rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm4Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm4rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm4rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm5Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm5rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm5rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm6Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm6rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm6rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm7Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm7rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm7rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm8Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm8rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm8rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm9Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm9rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm9rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm10Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4">
            <input type="range" id="spm10rating" ClientIDMode="static" min="0" max="5" value="0" step="1" runat="server" />
            <div class="rateit" data-rateit-mode="font" data-rateit-resetable="false" style="font-size: 30px" data-rateit-backingfld="#spm10rating"></div>
        </div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8">
            <asp:Button ID="SendInnSkjemaBtn" runat="server" Text="Send inn" class="btn btn-success btn-lg" OnClick="SendInnSkjemaBtn_Click"/>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
