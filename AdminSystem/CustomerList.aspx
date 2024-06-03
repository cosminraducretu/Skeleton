<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        /* Base styles */
        #form1 {
            width: 100%;
            max-width: 500px; /* Adjust max-width as needed */
            margin: 0 auto; /* Center align */
            position: relative;
        }

        /* Responsive positioning */
        @media screen and (max-width: 600px) {
            #form1 {
                max-width: 300px; /* Adjust max-width for smaller screens */
            }
            #lblError,
            #lstCustomerList,
            #btnAdd,
            #btnEdit,
            #btnDelete,
            #btnApplyFilter,
            #btnClearFilter,
            #lblEnter,
            #txtEnter,
            #btnRTMM {
                position: static !important; /* Reset position for smaller screens */
                width: 100% !important; /* Make elements full-width */
                margin-bottom: 10px; /* Add space between elements */
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 78px; top: 510px; position: absolute"></asp:Label>
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 52px; top: 70px; position: absolute; height: 183px; width: 266px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 61px; top: 291px; position: absolute; height: 28px; width: 61px" Text="Add" />
        </div>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 152px; top: 293px; position: absolute; height: 28px; width: 71px; right: 1071px;" Text="Edit" OnClick="btnEdit_Click" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDelete" runat="server" height="28px" OnClick="Button1_Click" style="z-index: 1; left: 250px; top: 292px; position: absolute; width: 71px" Text="Delete" />
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 74px; top: 412px; position: absolute; height: 26px; width: 92px" Text="Apply Filter" OnClick="btnApplyFilter_Click1" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 228px; top: 411px; position: absolute; height: 26px; width: 92px" Text="Clear Filter" OnClick="btnClearFilter_Click1" />
        <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 51px; top: 365px; position: absolute" Text="Enter a SubscriptionPlan  :"></asp:Label>
        <asp:TextBox ID="txtEnter" runat="server" style="z-index: 1; left: 226px; top: 364px; position: absolute; width: 80px; right: 988px"></asp:TextBox>
        <p>
            <asp:Button ID="btnRTMM" runat="server" OnClick="btnRTMM_Click" style="z-index: 1; left: 361px; top: 411px; position: absolute; width: 136px" Text="Return to Main Menu" />
        </p>
    </form>

</body>
</html>
