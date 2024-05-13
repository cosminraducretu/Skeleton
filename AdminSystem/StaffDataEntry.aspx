<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 229px;
            width: 1298px;
        }
        .auto-style3 {
            z-index: 1;
            left: 143px;
            top: 48px;
            position: absolute;
            width: 159px;
        }
        .auto-style4 {
            z-index: 1;
            left: 143px;
            top: 11px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 143px;
            top: 78px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 143px;
            top: 116px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 143px;
            top: 151px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 143px;
            top: 190px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 143px;
            top: 230px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 11px;
            top: 273px;
            position: absolute;
            width: 71px;
        }
        .auto-style13 {
            z-index: 1;
            left: 242px;
            top: 269px;
            position: absolute;
        }
    </style>
</head>
<body style="height: 367px; width: 1310px; margin-bottom: 0px">
    <form id="form1" runat="server">
        <div>
            <h2>&nbsp;</h2>
        </div>
        <asp:Label ID="lblStaffID" runat="server" height="22px" style="z-index: 1; left: 11px; top: 11px; position: absolute" Text="Staff ID" width="116px"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 11px; top: 79px; position: absolute" Text="Last Name" width="116px"></asp:Label>
        <p>
            <asp:Label ID="lblFirstName" runat="server" height="22px" style="z-index: 1; left: 11px; top: 49px; position: absolute" Text="First Name" width="116px"></asp:Label>
            <asp:Label ID="lblSalary" runat="server" height="22px" style="z-index: 1; left: 11px; top: 151px; position: absolute" Text="Salary" width="116px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style3" height="22px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtStaffID" runat="server" CssClass="auto-style4" height="22px" width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 11px; top: 118px; position: absolute; height: 22px" Text="Department" width="116px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style5" height="22px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtDepartment" runat="server" CssClass="auto-style6" height="22px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtSalary" runat="server" CssClass="auto-style7" height="22px" width="168px"></asp:TextBox>
            <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style9" Text="Availability" />
        </p>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style10"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" CssClass="auto-style12" height="29px" OnClick="btnOK_Click" Text="OK" width="77px" />
        </p>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style13" Text="Cancel" />
    </form>
</body>
</html>
