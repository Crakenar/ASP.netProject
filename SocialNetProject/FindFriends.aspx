<%@ Page Title="" Language="C#" MasterPageFile="~/NewsFeed.Master" AutoEventWireup="true" CodeBehind="FindFriends.aspx.cs" Inherits="SocialNetProject.FindFriends" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 80%; background-color: white; margin: 0 auto; min-height: 400px">
        <div class="people-nearby">
            <div class="google-maps">
            </div>

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <div class="nearby-user">
                        <div class="row">
                            <div class="col-md-2 col-sm-2">
                                <img src='<%# SetImagePath(Eval("profile_image"))  %>' alt="user" class="profile-photo-lg" />
                            </div>
                            <div class="col-md-7 col-sm-7">
                                <h5>
                                    <asp:LinkButton ID="LinkButton1" CssClass="profile-link" OnClick="LinkButton1_Click" runat="server"> <%# Eval("first_name") %> &nbsp; <%# Eval("last_name") %> </asp:LinkButton>
                                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("users_id") %>'></asp:Label>
                                </h5>
                                <p><%# Eval("city") %> &nbsp; <%# Eval("country") %>   </p>
                                <p class="text-muted"><%# Eval("short_bio") %>  </p>
                            </div>
                            <div class="col-md-3 col-sm-3">
                                 <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary pull-right" OnClick="LinkButton2_Click" runat="server">Add Friend  </asp:LinkButton>     
                            </div>
                            <div class="col-md-3 col-sm-3">
                                 <asp:LinkButton ID="LinkButton3" CssClass="btn btn-primary pull-right" OnClick="LinkButton3_Click" runat="server">Block Friend  </asp:LinkButton>     
                            </div>
                        </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>

