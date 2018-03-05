<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vurderingsskjema.aspx.cs" Inherits="VMS.vurderingsskjema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm1Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm1RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm2Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm2RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm3Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm3RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm4Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm4RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm5Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm5RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm6Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm6RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm7Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm7RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm8Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm8RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm9Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm9RadioknappDiv" runat="server"> </table></div>
    </div>
    <br />
    <br />
    <div class="Row">
        <div class="col-md-8"><asp:Label ID="spm10Lbl" runat="server" Font-Size="Large"></asp:Label></div>
        <div class="col-md-4"><table id="spm10RadioknappDiv" runat="server"> </table></div>
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
