<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="demonstraionusercontrols.demo" %>

<%@ Register Src="~/WebUserControl1.ascx" TagName="WebControl" TagPrefix="TWebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="mystyle.css">
    <title> </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <TWebControl:WebControl ID="header" runat="server"></TWebControl:WebControl> 
        </div>
    </form>
</body>
</html>
