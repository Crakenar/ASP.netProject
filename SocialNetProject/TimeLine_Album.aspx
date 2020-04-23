<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine_Album.aspx.cs" Inherits="SocialNetProject.TimeLine_Album" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Photo Album
                        ================================================= -->
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <ul class="album-photos">
                <li>
                    <div class="img-wrapper" data-toggle="modal" data-target='.photo-<%#Eval("album_id") %>'>
                        <img src='<%# SetImagePath(Eval("photo_url"))  %>' alt="photo" />
                    </div>
                    <div class='modal fade photo-<%#Eval("album_id") %>'>' tabindex="-1" role="dialog" aria-hidden="true">
                        <div class="modal-dialog modal-lg">
                            <div class="modal-content">
                                <img src='<%# SetImagePath(Eval("photo_url"))  %>' alt="photo" />
                            </div>
                        </div>
                    </div>
                </li>
            </ul>

        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
