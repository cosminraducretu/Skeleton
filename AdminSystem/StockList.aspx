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
            top: 34px;
            left: 10px;
            width: 273px;
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

        .lblEnterAvailability {
            top: -9px;
            left: 125px;
            right: 464px;
        }

        .txtFilterAvailability {
            top: 445px;
            left: 402px;
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

        .Availability {
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
            top: 432px;
            left: 14px;
            width: 124px;
        }

        .btnClearFilter {
            top: 430px;
            left: 313px;
            width: 124px;
        }

        .btnRTN {
            top: 430px;
            left: 153px;
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:ListBox ID="lstStockList" runat="server" CssClass="styled-label lstStockList" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged1" Height="309px" Width="366px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" CssClass="styled-button btnAdd" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" CssClass="styled-button btnDelete" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" CssClass="styled-button btnEdit" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Label ID="lblError" runat="server" CssClass="styled-label lblError"></asp:Label>
            <asp:Label ID="lblEnterAvailability" runat="server" CssClass="styled-label lblEnterAvailability" Text="choose if you want to filter availble IPTVs that are available or not Available:"></asp:Label>
            <asp:DropDownList ID="Availability" runat="server" Height="20px" Width="113px"><asp:ListItem Text="Available" Value="1" /><asp:ListItem Text="Unavailable" Value="0" /></asp:DropDownList>
            <asp:Button ID="btnFilter" runat="server" CssClass="styled-button btnFilter" OnClick="btnFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" CssClass="styled-button btnClearFilter" OnClick="btnClearFilter_Click" Text="Clear Filter" />
            <asp:Button ID="btnRTN" runat="server" CssClass="styled-button btnRTN" OnClick="btnRTN_Click" Text="Return to MainMenu" />
        </div>
    </form>
</body>
</html>
