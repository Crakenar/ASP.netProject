<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine_About.aspx.cs" Inherits="SocialNetProject.TimeLine_About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <div class="about-profile">
        <div class="about-content-block">
            <h4 class="grey"><i class="ion-ios-information-outline icon-in-title"></i>Personal Information</h4>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        </div>


        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>

                <div class="organization">
                    <img src="images/envato.png" alt="" class="pull-left img-org" />
                    <div class="work-info">
                        <h5><%#Eval("edu_title") %></h5>
                        <p><%#Eval("edu_desc") %> <span class="text-grey">start : <%#Eval("start_year") %> - Finish : <%# Eval("finish_year") %> </span></p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
    <div class="about-content-block">
        <h4 class="grey"><i class="ion-ios-location-outline icon-in-title"></i>Location</h4>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
    <div class="about-content-block">
        <h4 class="grey"><i class="ion-ios-heart-outline icon-in-title"></i>BirthDate</h4>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
    <div class="about-content-block">
        <h4 class="grey"><i class="ion-ios-chatbubble-outline icon-in-title"></i>Account creation Date</h4>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
    </div>

</asp:Content>
