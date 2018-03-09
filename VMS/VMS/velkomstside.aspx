<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="velkomstside.aspx.cs" Inherits="VMS.velkomstside" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Velkommen til vurderingssystemet!</h1>
        <p>Trykk på "Logg inn" for å logge inn med en student-ID eller trykk "Fortsett" for å logge inn uten student-ID</p>
        
        <br />
        <!--- Knapp som trigger modalen -->
        <asp:Button class="btn btn-success btn-lg" ID="LoginBtn" data-toggle="modal" data-target="#logginnModal" runat="server" Text="Logg inn" />
        <asp:Button class="btn btn-primary btn-lg" ID="continue" runat="server" Text="Fortsett" OnClick="continue_Click" />

        <!-- Modal -->
        <div class="modal fade" id="logginnModal" role="dialog">
            <div class="modal-dialog">

                <!-- Innholdet i modalen -->
                <div class="modal-content">
                    <div class="modal-header">
                        <asp:Button class="close" data-dismiss="modal" runat="server" Text="&times;" />
                        <h4 class="modal-title">Innlogging</h4>
                    </div>
                    <div class="modal-body">
                        <asp:Label ID="Melding" runat="server" Text="Logg inn med Student-ID"></asp:Label>
                            <div class="input-group">
                                <asp:TextBox CssClass="form-control" ID="StudentID" runat="server" placeholder="000000" ></asp:TextBox>
                                <span class="input-group-btn">
                                    <asp:Button CssClass="btn btn-success" ID="Logginn" runat="server" Text="Logg inn" OnClick="Logginn_Click"></asp:Button>
                                </span>
                             </div>
                        <asp:Label ID="Feilmelding" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="modal-footer">
                        <asp:Button class="btn btn-default" runat="server" data-dismiss="modal" Text="Lukk"/>
                    </div>
                </div>
            </div>
         </div>
</asp:Content>
