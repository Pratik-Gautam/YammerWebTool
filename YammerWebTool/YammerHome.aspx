<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YammerHome.aspx.cs" Inherits="YammerWebTool.YammerHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" Text="Please input all the message ids here comma seperated"></asp:Label><br /><br />
        <asp:TextBox runat="server" ID="txtMessageIds"></asp:TextBox>
        <br /><br />
        <asp:Button runat="server" ID="btnDeleteMessages" OnClick="btnDeleteMessages_Click" Text="Delete Messages" />
        <br /><br />
        <asp:Label runat="server" ID="lblStatus"></asp:Label>
    </div>
    </form>
</body>
</html>
