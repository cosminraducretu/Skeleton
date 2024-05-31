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
        .auto-style9 {
            z-index: 1;
            left: 185px;
            top: 409px;
            position: absolute;
            width: 108px;
            right: 1192px;
        }
        .auto-style10 {
            z-index: 1;
            left: 129px;
            top: 462px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 18px;
            top: 584px;
            position: absolute;
            width: 71px;
            right: 725px;
        }
        .auto-style13 {
            z-index: 1;
            left: 240px;
            top: 584px;
            position: absolute;
            width: 65px;
        }
        .auto-style14 {
            z-index: 1;
            left: 129px;
            top: 584px;
            position: absolute;
            right: 614px;
        }
        #form2 {
            height: 229px;
            width: 1298px;
        }
        </style>
</head>
<body style="height: 367px; width: 1310px; margin-bottom: 0px">
    <form id="form1" runat="server">
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style13" Text="Cancel" height="29px" TabIndex="9" OnClick="btnCancel_Click1" />
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style9" Text="Active" TabIndex="5" />
        <asp:Label ID="lblStaffID" runat="server" height="19" style="z-index: 1; left: 10px; top: 114px; position: absolute" Text="StaffID"></asp:Label>
        <asp:Label ID="lblError0" runat="server" CssClass="auto-style10"></asp:Label>
        <asp:Button ID="btnOK0" runat="server" CssClass="auto-style12" height="29px" OnClick="btnOK_Click" Text="OK" width="68px" TabIndex="6" />
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute" Text="First Name"></asp:Label>
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style14" height="29px" OnClick="btnFind_Click" TabIndex="7" Text="Find" width="68px" />
        <asp:Button ID="btnRTN" runat="server" height="29px" OnClick="btnRTN_Click" style="z-index: 1; left: 345px; top: 584px; position: absolute; width: 147px" Text="Return to MainMenu" />
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 12px; top: 200px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 13px; top: 253px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 15px; top: 307px; position: absolute" Text="Age"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 189px; top: 114px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 189px; top: 148px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 189px; top: 200px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 189px; top: 253px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 189px; top: 307px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
