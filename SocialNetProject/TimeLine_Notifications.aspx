<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine_Notifications.aspx.cs" Inherits="SocialNetProject.TimeLine_Notifications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h2>Activities</h2>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>

                <div><%#Eval("first_name") %> <%#Eval("last_name") %>     <%#Eval("activiy") %>  <%# SetPrettyDate(Eval("activity_time")) %> </div>
            </ItemTemplate>
        </asp:Repeater>


    </div>

    <div>
        <h2>Friend Requests</h2>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <div class="col-md-3 col-sm-3">
               
                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("user_id_1") %>'></asp:Label>
                        <%#Eval("friendship_status") %>
                    <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary pull-right" OnClick="LinkButton2_Click" runat="server">Add Friend </asp:LinkButton>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>






</asp:Content>
