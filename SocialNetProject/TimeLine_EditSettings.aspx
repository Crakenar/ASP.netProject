<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimeLine_EditSettings.aspx.cs" Inherits="SocialNetProject.TimeLine_EditSettings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Profile Settings
                        ================================================= -->
    <div class="edit-profile-container">
        <div class="block-title">
            <h4 class="grey"><i class="icon ion-ios-settings"></i>Account Settings</h4>
            <div class="line"></div>
            <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate</p>
            <div class="line"></div>
        </div>
        <div class="edit-block">
            <div class="settings-block">
                <div class="row">
                    <div class="col-sm-9">
                        <div class="switch-description">
                            <div><strong>Enable follow me</strong></div>
                            <p>Enable this if you want people to follow you</p>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="toggle-switch">
                            <label class="radio-inline">
                                <asp:RadioButton ID="RadioButton1" GroupName="Notif" runat="server" Text="Oui" Checked="True" />
                            </label>
                            <label class="radio-inline">
                                <asp:RadioButton ID="RadioButton2" GroupName="Notif" runat="server" Text="Non" />
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="line"></div>
            <div class="settings-block">
                <div class="row">
                    <div class="col-sm-9">
                        <div class="switch-description">
                            <div><strong>Send me notifications</strong></div>
                            <p>Send me notification emails my friends like, share or message me</p>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="toggle-switch">
                            <div class="form-group gender">
                                <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton3" GroupName="Notif" runat="server" Text="Oui" Checked="True" />
                                </label>
                                <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton4" GroupName="Notif" runat="server" Text="Non" />
                                </label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="line"></div>
            <div class="settings-block">
                <div class="row">
                    <div class="col-sm-9">
                        <div class="switch-description">
                            <div><strong>Text messages</strong></div>
                            <p>Send me messages to my cell phone</p>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="toggle-switch">
                          <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton5" GroupName="Notif" runat="server" Text="Oui" Checked="True" />
                                </label>
                                <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton6" GroupName="Notif" runat="server" Text="Non" />
                                </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="line"></div>
            <div class="settings-block">
                <div class="row">
                    <div class="col-sm-9">
                        <div class="switch-description">
                            <div><strong>Enable tagging</strong></div>
                            <p>Enable my friends to tag me on their posts</p>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="toggle-switch">
                           <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton7" GroupName="Notif" runat="server" Text="Oui" Checked="True" />
                                </label>
                                <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton8" GroupName="Notif" runat="server" Text="Non" />
                                </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="line"></div>
            <div class="settings-block">
                <div class="row">
                    <div class="col-sm-9">
                        <div class="switch-description">
                            <div><strong>Enable sound</strong></div>
                            <p>You'll hear notification sound when someone sends you a private message</p>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="toggle-switch">
                            <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton9" GroupName="Notif" runat="server" Text="Oui" Checked="True" />
                                </label>
                                <label class="radio-inline">
                                    <asp:RadioButton ID="RadioButton10" GroupName="Notif" runat="server" Text="Non" />
                                </label>
                        </div>
                    </div>
                     <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Save Changes" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
