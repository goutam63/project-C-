<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayersList.aspx.cs" Inherits="BCCIproject.PlayersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdplayers" runat="server" AutoGenerateColumns="False" DataKeyNames="PlayerID" DataSourceID="Sqldsplayers">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="PlayerID" HeaderText="PlayerID" InsertVisible="False" ReadOnly="True" SortExpression="PlayerID" />
                    <asp:BoundField DataField="PlayerName" HeaderText="PlayerName" SortExpression="PlayerName" />
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                    <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="Sqldsplayers" runat="server" ConnectionString="<%$ ConnectionStrings:BCCIConnectionString %>" DeleteCommand="DELETE FROM [Players] WHERE [PlayerID] = @PlayerID" InsertCommand="INSERT INTO [Players] ([PlayerName], [Age], [city]) VALUES (@PlayerName, @Age, @city)" SelectCommand="SELECT * FROM [Players]" UpdateCommand="UPDATE [Players] SET [PlayerName] = @PlayerName, [Age] = @Age, [city] = @city WHERE [PlayerID] = @PlayerID">
                <DeleteParameters>
                    <asp:Parameter Name="PlayerID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="PlayerName" Type="String" />
                    <asp:Parameter Name="Age" Type="Int32" />
                    <asp:Parameter Name="city" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="PlayerName" Type="String" />
                    <asp:Parameter Name="Age" Type="Int32" />
                    <asp:Parameter Name="city" Type="String" />
                    <asp:Parameter Name="PlayerID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
