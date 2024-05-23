<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 304px; top: 264px; position: absolute" Text="UserName :"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 304px; top: 311px; position: absolute" Text="Password :"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 388px; top: 264px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 389px; top: 311px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 595px; top: 291px; position: absolute" Text="lblError"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 348px; top: 389px; position: absolute" Text="Login" width="60px" />
            <asp:Button ID="btnCancel" runat="server" Height="26px" style="z-index: 1; left: 456px; top: 388px; position: absolute" Text="Cancel" Width="60px" OnClick="btnCancel_Click" />
            <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 400px; top: 193px; position: absolute" Text="LOGIN PAGE"></asp:Label>
        </div>
    </form>
</body>
</html>
