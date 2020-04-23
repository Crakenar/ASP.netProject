<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="SocialNetProject.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #EEEEEE"; width:800px;  margi:0 auto; min-height:600px">
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="90%" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                 <AlternatingRowStyle BackColor="White" />
                 <Columns>
                     <asp:BoundField DataField="first_name" HeaderText="First name" />
                     <asp:BoundField DataField="last_name" HeaderText="Last name" />
                     <asp:BoundField DataField="users_email" HeaderText="User Email" />
                     <asp:TemplateField AccessibleHeaderText="Action" HeaderText="Action">
                         <ItemTemplate>
                             <asp:Button ID="Button1" runat="server" BackColor="Red" OnClick="Button1_Click" ForeColor="White" Text="delete" />
                             <asp:Label ID="Label1" runat="server" Text='<%#Eval("users_id") %>'></asp:Label>
                         </ItemTemplate>
                     </asp:TemplateField>
                 </Columns>

                 <FooterStyle BackColor="#CCCC99" />
                 <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                 <RowStyle BackColor="#F7F7DE" />
                 <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#FBFBF2" />
                 <SortedAscendingHeaderStyle BackColor="#848384" />
                 <SortedDescendingCellStyle BackColor="#EAEAD3" />
                 <SortedDescendingHeaderStyle BackColor="#575357" />

             </asp:GridView>
        </div>
       
    </form>
</body>
</html>
