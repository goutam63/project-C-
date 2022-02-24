<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="userregistration.WebForm1" %>

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
                    <td> Full Name</td>
                    <td>
                        <asp:TextBox ID="txtfn" runat="server" placeholder="enter your full name"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" placeholder="enter your Address" TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>gender</td>
                    <td>
                        <asp:RadioButton GroupName="User" ID="RadioButton1" runat="server" Text="Male" OnCheckedChanged="RadioButton1_CheckedChanged" /><br />
                        <asp:RadioButton GroupName="User" ID="RadioButton2" runat="server" Text="Famle" OnCheckedChanged="RadioButton2_CheckedChanged"/><br />
                        <asp:RadioButton GroupName="User" ID="RadioButton3" runat="server" Text="Other" OnCheckedChanged="RadioButton3_CheckedChanged"/>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" placeholder="enter your Email" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="txtphone" runat="server" placeholder="+91-123-4567-899" TextMode="Phone"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="txtuser" runat="server" placeholder="enter your UserName"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server" placeholder="enter your password" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td align="right">
                        <asp:Button ID="btsn" runat="server" Text="Register" OnClick="btsn_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
