<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 120px; top: 373px; position: absolute"></asp:Label>
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 282px; width: 288px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 57px; top: 319px; position: absolute; height: 35px; width: 71px" Text="Add" />
        </div>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 178px; top: 317px; position: absolute; height: 35px; width: 71px" Text="Edit" OnClick="btnEdit_Click" />
    </form>
    <p>
        E</p>
</body>
</html>
