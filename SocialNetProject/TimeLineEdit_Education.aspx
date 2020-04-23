<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLineEdit_Education.aspx.cs" Inherits="SocialNetProject.TimeLineEdit_Education" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="tab-pane active" id="register">
        <h3>Edit Education/Work !</h3>
        <p class="text-muted"></p>

    <div class="form-group gender">
            <label class="radio-inline">
                <asp:radiobutton id="RadioButton1" groupname="edu" runat="server" text="Education" checked="True" />
            </label>
            <label class="radio-inline">
                <asp:radiobutton id="RadioButton2" groupname="edu" runat="server" text="Work" />
            </label>
        </div>

    
        <div class="row">
            <div class="form-group col-xs-12">
                <label for="bio" class="sr-only">Title</label>
                <asp:textbox id="TextBox1" cssclass="form-control input-group-lg" placeholder="Your Title" runat="server"></asp:textbox>
            </div>
        </div>
       
        <!--Register Form-->

        <div class="row">
            <div class="form-group col-xs-6">
                <label for="start" class="sr-only">Start Year</label>
                <asp:textbox id="TextBox2" cssclass="form-control input-group-lg" placeholder="First name" runat="server"></asp:textbox>
            </div>
            <div class="form-group col-xs-6">
                <label for="finish" class="sr-only">End Year</label>
                <asp:textbox id="TextBox3" cssclass="form-control input-group-lg" placeholder="Last name" runat="server"></asp:textbox>
            </div>
        </div>

    <div class="form-group gender">
        <label class="radio-inline">
            <asp:CheckBox id="CheckBox1"  runat="server" text="finished?"></asp:CheckBox>
    </div>

    <div class="row">
        <p class="birth"><strong>Description!</strong></p>
        <div class="form-group col-xs-12">
            <label for="bio" class="sr-only">Description</label>
            <asp:textbox id="TextBox4" cssclass="form-control input-group-lg" placeholder="About..." runat="server"></asp:textbox>
        </div>
    </div>







    <asp:button id="Button1" cssclass="btn btn-primary" runat="server" text="EDIT INFO" OnClick="Button1_Click" />

</div>

    </label>

</asp:Content>
