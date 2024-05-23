<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 37px;
            position: absolute;
            height: 227px;
            width: 294px;
        }
        .auto-style2 {
            z-index: 1;
            left: 14px;
            top: 382px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 309px;
            top: 382px;
            position: absolute;
            right: 1052px;
        }
        .auto-style4 {
            z-index: 1;
            left: 163px;
            top: 382px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 389px;
            top: 76px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 14px;
            top: 446px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 214px;
            top: 445px;
            position: absolute;
            width: 215px;
        }
        .auto-style8 {
            z-index: 1;
            left: 14px;
            top: 493px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 309px;
            top: 493px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" height="29px" width="124px" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style3" OnClick="btnDelete_Click" Text="Delete" height="29px" width="124px" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style4" height="29px" Text="Edit" width="124px" OnClick="btnEdit_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <asp:Label ID="lblEnterAddress" runat="server" CssClass="auto-style6" Text="Enter an address:"></asp:Label>
        <asp:TextBox ID="txtFilterAddress" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" CssClass="auto-style8" OnClick="btnFilter_Click" Text="Apply Filter" height="29px" width="124px" />
        <asp:Button ID="btnClearFilter" runat="server" CssClass="auto-style9" height="29px" OnClick="btnClearFilter_Click" Text="Clear Filter" width="124px" />
    </form>
</body>
</html>
