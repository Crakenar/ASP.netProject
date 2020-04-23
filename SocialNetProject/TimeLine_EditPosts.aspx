<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine_EditPosts.aspx.cs" Inherits="SocialNetProject.TimeLine_EditPosts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="tab-pane active">
        <h3>New POST !</h3>
        <p class="text-muted"></p>

        <div class="row">
            <p ><strong> Text!</strong></p>
            <div class="form-group col-xs-12">
                <label class="sr-only">Text:</label>
                <asp:textbox id="TextBox1" cssclass="form-control input-group-lg" placeholder="What is in your mind..." runat="server"></asp:textbox>
            </div>
        </div>

        <div class="row">
            <p><strong>Post Image</strong></p>
            <div class="form-group col-xs-12">
                <label for="Pimage" class="sr-only">Post Image</label>

                <asp:fileupload id="FileUpload1" runat="server" />
                &nbsp;
        <asp:button id="uploadBtn" runat="server" text="Upload Image" onclick="uploadBtn_Click" />
                <br />
                <asp:label id="lbl_error" runat="server" text="Label"></asp:label>
                <br />
                <asp:image id="Image1" runat="server" height="200px" width="200px" />

            </div>
        </div>

         <asp:button id="Button1" cssclass="btn btn-primary" runat="server" text="New POST" OnClick="Button1_Click" />

    </div>


</asp:Content>
