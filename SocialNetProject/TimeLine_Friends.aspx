<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine_Friends.aspx.cs" Inherits="SocialNetProject.TimeLine_Friends" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="friend-list">
        <div class="row">

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                  <div class="col-md-6 col-sm-6">
                      <div class="friend-card">
                          <div><%#Eval("first_name") %> </div>
                          <img src='<%# SetImagePath(Eval("background_image"))  %>' alt="profile-cover" class="img-responsive cover" />
                          <div class="card-info">
                              <img src='<%# SetImagePath(Eval("profile_image"))  %>' alt="user" class="profile-photo-lg" />
                              <div class="friend-info">
                                    <asp:LinkButton ID="LinkButton1" CssClass="profile-link" OnClick="LinkButton1_Click" runat="server"> <%# Eval("first_name") %> &nbsp; <%# Eval("last_name") %> </asp:LinkButton>
                                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("users_id") %>'></asp:Label>
                                  <p> <%#Eval("about_me") %></p>
                              </div>
                          </div>
                      </div>
                  </div>
                </ItemTemplate>
            </asp:Repeater>

             

        </div>
    </div>
</asp:Content>
