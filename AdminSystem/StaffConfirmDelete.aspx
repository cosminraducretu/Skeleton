<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            &nbsp;</p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 430px; top: 234px; position: absolute; width: 324px" Text="Are you sure you wanna delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 455px; top: 276px; position: absolute; height: 31px; width: 90px;" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="31px" OnClick="btnNo_Click" style="z-index: 1; left: 643px; top: 276px; position: absolute" Text="No" width="90px" />
    </form>
</body>
</html>
