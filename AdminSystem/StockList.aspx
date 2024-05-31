<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .container {
            position: relative;
            width: 100%;
            max-width: 500px; /* Adjust max-width as needed */
            margin: 0 auto; /* Center align */
        }
        
        /* Base styles for labels, buttons, and textboxes */
        .styled-label,
        .styled-button,
        .styled-textbox {
            position: absolute;
            z-index: 1;
        }
        
        /* Positioning styles for specific elements */
        .lstStaffList {
            top: 37px;
            left: 10px;
            height: 227px;
            width: 294px;
        }

        .lblError {
            top: 76px;
            left: 389px;
        }

        .lblEnterAddress {
            top: 446px;
            left: 14px;
        }

        .txtFilterAddress {
            top: 445px;
            left: 352px;
            width: 115px;
        }

        .btnAdd {
            top: 382px;
            left: 14px;
            width: 124px;
            right: 653px;
        }

        .btnDelete {
            top: 382px;
            left: 309px;
            width: 124px;
        }

        .btnEdit {
            top: 382px;
            left: 163px;
            width: 124px;
        }

        .btnFilter {
            top: 492px;
            left: 14px;
            width: 124px;
        }

        .btnClearFilter {
            top: 492px;
            left: 322px;
            width: 124px;
        }

        .btnRTN {
            top: 492px;
            left: 153px;
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:ListBox ID="lstStockList" runat="server" CssClass="styled-label lstStaffList" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged1"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" CssClass="styled-button btnAdd" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" CssClass="styled-button btnDelete" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" CssClass="styled-button btnEdit" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Label ID="lblError" runat="server" CssClass="styled-label lblError"></asp:Label>
            <asp:Label ID="lblEnterAddress" runat="server" CssClass="styled-label lblEnterAddress" Text="Shoose if want availble IPTVs that are available or not:"></asp:Label>
            <asp:CheckBox ID="Checkav" runat="server" CssClass="styled-textbox txtFilterAddress" Text="[Availability]"></asp:CheckBox>
            <asp:Button ID="btnFilter" runat="server" CssClass="styled-button btnFilter" OnClick="btnFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" CssClass="styled-button btnClearFilter" OnClick="btnClearFilter_Click" Text="Clear Filter" />
            <asp:Button ID="btnRTN" runat="server" CssClass="styled-button btnRTN" OnClick="btnRTN_Click" Text="Return to MainMenu" />
        </div>
    </form>
</body>
</html>
