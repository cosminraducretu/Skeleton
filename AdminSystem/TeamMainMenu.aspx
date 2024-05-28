<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 234px;
            height: 227px;
            margin-left: 480px;
            margin-top: 99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnStockMS" runat="server" OnClick="btnStockMS_Click" style="z-index: 1; left: 512px; top: 423px; position: absolute; height: 36px; width: 191px;" Text="Stock Management System" />
        <asp:Button ID="btnCMS" runat="server" OnClick="btnCMS_Click" style="z-index: 1; left: 395px; top: 370px; position: absolute; height: 36px; width: 191px; right: 469px;" Text="Customer Managmt System" />
        <p>
            <asp:Button ID="btnSMS" runat="server" OnClick="btnSMS_Click" style="z-index: 1; left: 623px; top: 370px; position: absolute; width: 191px; height: 36px;" Text="Staff Management System" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Algerian" Font-Size="X-Large" Height="40px" style="z-index: 1; left: 520px; top: 132px; position: absolute; width: 297px" Text="IPTV Main Menu"></asp:Label>
        </p>
    </form>
    <p>
        <img class="auto-style1" src="download.jpeg" /></p>
</body>
</html>
