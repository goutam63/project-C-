<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication3.WebForm" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Full Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server" placeholder="enter your full name"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" placeholder="enter your Address"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gnder</td>
                    <td>
                        <asp:RadioButton GroupName="User" ID="RadioButton1" runat="server" Text="Male" /><br />
                        <asp:RadioButton GroupName="User" ID="RadioButton2" runat="server" Text="Female"/><br />
                        <asp:RadioButton GroupName="User" ID="RadioButton3" runat="server" Text="Other"/>
                    </td>
                </tr>
                <tr>
                    <td>phone</td>
                    <td>
                        <asp:TextBox ID="txtphone" runat="server" placeholder="+977-012-3456"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>email</td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" placeholder="example@example.com" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server" placeholder="User"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td align="right">
                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserRegisterConnectionString2 %>" SelectCommand="SELECT * FROM [userreg]"></asp:SqlDataSource>
</body>
</html>
