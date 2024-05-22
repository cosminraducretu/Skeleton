<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            z-index: 1;
            left: 237px;
            top: 236px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 52px;
            top: 139px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 98px;
            top: 236px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnNo" runat="server" CssClass="auto-style2" height="29px" Text="No" width="42px" OnClick="btnNo_Click" />
        </p>
        <asp:Label ID="lblMsg" runat="server" CssClass="auto-style3" Text="Are you sure you want to delete this record ?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style4" OnClick="btnYes_Click" Text="Yes" />
    </form>
</body>
</html>
