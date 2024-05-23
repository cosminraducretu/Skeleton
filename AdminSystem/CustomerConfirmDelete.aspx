<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 682px; top: 322px; position: absolute; height: 35px; width: 120px" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" height="35px" OnClick="btnNo_Click" style="z-index: 1; left: 450px; top: 320px; position: absolute" Text="No" width="120px" />
        <asp:Label ID="lblAreYou" runat="server" style="z-index: 1; left: 487px; top: 239px; position: absolute" Text="Are you sure you wanna delete this record?"></asp:Label>
    </form>
</body>
</html>
