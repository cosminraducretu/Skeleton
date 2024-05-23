<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnStockMS" runat="server" height="44px" OnClick="btnStockMS_Click" style="z-index: 1; left: 879px; top: 293px; position: absolute" Text="Stock Management System" width="251px" />
        <asp:Button ID="btnCMS" runat="server" OnClick="btnCMS_Click" style="z-index: 1; left: 243px; top: 292px; position: absolute; height: 44px; width: 251px" Text="Customer Management System" />
        <p>
            <asp:Button ID="btnSMS" runat="server" height="44px" OnClick="btnSMS_Click" style="z-index: 1; left: 568px; top: 292px; position: absolute" Text="Staff Management System" width="251px" />
        </p>
        <p>
            <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 612px; top: 192px; position: absolute; width: 181px" Text="Customer Main Menu Page"></asp:Label>
        </p>
    </form>
</body>
</html>
