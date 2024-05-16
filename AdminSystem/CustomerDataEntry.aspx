<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 570px; width: 740px">
    <form id="form1" runat="server">
        <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 36px; top: 80px; position: absolute" Text="ID" width="162px"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 198px; top: 81px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 196px; top: 231px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 38px; top: 131px; position: absolute" Text="FirstName" width="162px"></asp:Label>
            &nbsp;</p>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 197px; top: 129px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 38px; top: 177px; position: absolute" Text="LastName" width="162px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 197px; top: 180px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p style="height: 12px">
            <asp:TextBox ID="txtSubscriptionPlan" runat="server" style="z-index: 1; left: 199px; top: 279px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 36px; top: 230px; position: absolute" Text="Email" width="162px"></asp:Label>
        </p>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 196px; top: 336px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSubscriptionPlan" runat="server" style="z-index: 1; left: 35px; top: 280px; position: absolute; bottom: 447px" Text="SubscriptionPlan"></asp:Label>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 38px; top: 333px; position: absolute" Text="Age" width="162px"></asp:Label>
        <asp:CheckBox ID="ChkSubscriptionStatus" runat="server" style="z-index: 1; left: 150px; top: 392px; position: absolute; height: 46px; width: 207px" Text="SubscriptionStatus" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 37px; top: 436px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 49px; top: 487px; position: absolute; width: 51px; " Text="OK" BackColor="#99CCFF" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 485px; position: absolute" Text="Cancel" BackColor="#FFCCCC" />
    </form>
</body>
</html>
