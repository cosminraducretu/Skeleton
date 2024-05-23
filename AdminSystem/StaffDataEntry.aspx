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
            top: 150px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 143px;
            top: 190px;
            position: absolute;
            width: 108px;
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
            top: 364px;
            position: absolute;
            width: 71px;
            }
        .auto-style13 {
            z-index: 1;
            left: 242px;
            top: 364px;
            position: absolute;
            width: 65px;
        }
        .auto-style14 {
            z-index: 1;
            left: 130px;
            top: 364px;
            position: absolute;
        }
        #form2 {
            height: 229px;
            width: 1298px;
        }
        </style>
</head>
<body style="height: 367px; width: 1310px; margin-bottom: 0px">
    <form id="form1" runat="server">
        <div>
            <h2>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style3" height="22px" width="168px" TabIndex="2"></asp:TextBox>
            </h2>
        </div>
        <asp:Label ID="lblStaffID" runat="server" height="22px" style="z-index: 1; left: 11px; top: 11px; position: absolute" Text="Staff ID" width="116px"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 11px; top: 79px; position: absolute" Text="Last Name" width="116px"></asp:Label>
        <p>
            <asp:Label ID="lblFirstName" runat="server" height="22px" style="z-index: 1; left: 11px; top: 49px; position: absolute" Text="First Name" width="116px"></asp:Label>
            <asp:Label ID="lblSalary" runat="server" height="22px" style="z-index: 1; left: 11px; top: 151px; position: absolute" Text="Age" width="116px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 11px; top: 118px; position: absolute; height: 22px" Text="Address" width="116px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style5" height="22px" width="168px" TabIndex="3"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style6" height="22px" width="168px" TabIndex="4"></asp:TextBox>
            <asp:TextBox ID="txtAge" runat="server" CssClass="auto-style7" height="22px" width="168px" TabIndex="5"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" CssClass="auto-style12" height="29px" OnClick="btnOK_Click" Text="OK" width="68px" TabIndex="6" />
        </p>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style13" Text="Cancel" height="29px" TabIndex="9" />
        <div>
            <h2>
                &nbsp;</h2>
        </div>
        <asp:Label ID="lblStaffID0" runat="server" height="22px" style="z-index: 1; left: 11px; top: 11px; position: absolute" Text="Staff ID" width="116px"></asp:Label>
        <asp:Label ID="lblLastName0" runat="server" style="z-index: 1; left: 11px; top: 79px; position: absolute" Text="Last Name" width="116px"></asp:Label>
        <p>
            <asp:Label ID="lblFirstName0" runat="server" height="22px" style="z-index: 1; left: 11px; top: 49px; position: absolute" Text="First Name" width="116px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style9" Text="Active" TabIndex="5" />
        </p>
        <asp:Label ID="lblError0" runat="server" CssClass="auto-style10"></asp:Label>
        <p>
            <asp:Button ID="btnOK0" runat="server" CssClass="auto-style12" height="29px" OnClick="btnOK_Click" Text="OK" width="68px" TabIndex="6" />
        </p>
        <asp:Button ID="btnCancel0" runat="server" CssClass="auto-style13" Text="Cancel" height="29px" TabIndex="8" width="68px" />
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style14" height="29px" OnClick="btnFind_Click" TabIndex="7" Text="Find" width="68px" />
        <asp:TextBox ID="txtStaff" runat="server" height="22px" style="z-index: 1; left: 143px; top: 12px; position: absolute" width="168px"></asp:TextBox>
    </form>
</body>
</html>
