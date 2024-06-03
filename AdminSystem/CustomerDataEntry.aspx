<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 570px; width: 740px">
    <form id="form1" runat="server">
        <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 760px; top: 79px; position: absolute; bottom: 578px;" Text="ID" width="162px"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 903px; top: 79px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 903px; top: 231px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 760px; top: 131px; position: absolute" Text="FirstName" width="162px"></asp:Label>
            &nbsp;</p>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 903px; top: 129px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 760px; top: 177px; position: absolute" Text="LastName" width="162px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 903px; top: 180px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p style="height: 12px">
            <asp:TextBox ID="txtSubscriptionPlan" runat="server" style="z-index: 1; left: 903px; top: 279px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 760px; top: 230px; position: absolute" Text="Email" width="162px"></asp:Label>
        </p>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 903px; top: 336px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSubscriptionPlan" runat="server" style="z-index: 1; left: 760px; top: 280px; position: absolute; bottom: 370px; width: 110px;" Text="SubscriptionPlan"></asp:Label>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 760px; top: 333px; position: absolute" Text="Age" width="162px"></asp:Label>
        <asp:CheckBox ID="ChkSubscriptionStatus" runat="server" style="z-index: 1; left: 863px; top: 389px; position: absolute; height: 46px; width: 207px" Text="SubscriptionStatus" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 866px; top: 440px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 682px; top: 469px; position: absolute; width: 90px; right: 390px;" Text="OK" BackColor="#99CCFF" height="35px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 786px; top: 469px; position: absolute" Text="Cancel" BackColor="#FFCCCC" height="35px" width="90px" OnClick="btnCancel_Click" />
        <asp:Button ID="BtnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 890px; top: 468px; position: absolute; height: 35px; width: 90px;" Text="Find" BackColor="#CCFF66" />
        <p>
            <asp:Button ID="btnRTMM" runat="server" OnClick="btnRTMM_Click" style="z-index: 1; left: 996px; top: 471px; position: absolute; width: 135px" Text="Return to Main Menu" />
        </p>
    </form>
</body>
</html>
