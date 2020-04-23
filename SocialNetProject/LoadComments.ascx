<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoadComments.ascx.cs" Inherits="SocialNetProject.LoadComments" %>


<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <div class="post-comment">
            <img src='<%#SetImagePath(Eval("profile_image")) %>' alt="" class="profile-photo-sm" />
            <p><a href="timeline.html" class="profile-link"><%#Eval("first_name") %> </a>  <%#Eval("comment") %> </p>
        </div>
    </ItemTemplate>
</asp:Repeater>
