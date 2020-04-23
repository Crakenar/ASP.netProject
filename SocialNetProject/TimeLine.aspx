<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine.aspx.cs" Inherits="SocialNetProject.TimeLine1" %>

<%@ Register Src="~/LoadComments.ascx" TagPrefix="uc1" TagName="LoadComments" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="create-post" style="min-height: 50px;">
    </div>


    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="post-content">

                <!--Post Date-->
                <div class="post-date hidden-xs hidden-sm">
                    <h5>Sarah</h5>
                    <p class="text-grey"><%# SetPrettyDate(Eval("post_datetime")) %> </p>
                </div>
                <!--Post Date End-->
                <img src='<%# SetImagePath(Eval("post_image")) %>' alt="post-image" class="img-responsive post-image" />
                <div class="post-container">
                    <img src="images/users/user-1.jpg" alt="user" class="profile-photo-md pull-left" />
                    <div class="post-detail">
                        <div class="user-info">
                            <h5><a href="timeline.html" class="profile-link">Sarah Cruiz</a> <span class="following">following</span></h5>
                            <p class="text-muted">Yesterday</p>
                        </div>
                        <div class="reaction">
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn text-green" OnClick="LinkButton1_Click">
                            <i class="icon ion-thumbsup"><%# Eval("post_like") %></i> </asp:LinkButton>
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn text-red" OnClick="LinkButton2_Click">
                            <i class="fa fa-thumbs-down"><%# Eval("post_dislike") %></i> </asp:LinkButton>

                            <asp:LinkButton ID="LinkButton3" CssClass="btn text-red" OnClick="LinkButton3_Click" runat="server" Visible='<%# SetVisibility() %>'>
                            <i class="fa fa-trash" > Delete</i> </asp:LinkButton>

                            <asp:Label ID="lbl_postID" runat="server" Text='<%# Eval("post_id") %>'></asp:Label>
                        </div>
                        <div class="line-divider"></div>
                        <div class="post-text">
                            <p class="text-grey"><%# Eval("post_content") %>> </p>
                        </div>


                        <div class="line-divider"></div>
                        <div class="form-group col-xs-10">
                            <asp:TextBox ID="txt_comment_text" CssClass="form-control input-group-lg" placeholder="Comment..." runat="server"></asp:TextBox>
                           
                        </div>
                        <div class="form-group col-xs-2">
                            <asp:button id="Button1" cssclass="btn btn-warning" style="display:inline" runat="server" text="comment"  onClick="Button1_Click" />
                            <asp:Label ID="lbl_postID2" runat="server" Text='<%# Eval("post_id") %>'></asp:Label>

                        </div>

                        <uc1:LoadComments runat="server" ID="LoadComments" />
                         <asp:Label ID="lbl_postID3" runat="server" Text='<%# Eval("post_id") %>'></asp:Label>



                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
