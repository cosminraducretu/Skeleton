<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 365px">
    <form id="form1" runat="server">
        <div style="height: 19px">
        </div>
        <asp:Label ID="lblStockId" runat="server" height="19px" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Stock ID" width="69px"></asp:Label>
        <asp:TextBox ID="txtStockid" runat="server" height="22px" style="z-index: 1; left: 141px; top: 34px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" height="19px" style="z-index: 1; left: 10px; top: 78px; position: absolute" Text="Quantity" width="69px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" height="22px" style="z-index: 1; left: 141px; top: 80px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 10px; top: 133px; position: absolute; bottom: 524px" Text="Description"></asp:Label>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" height="22px" style="z-index: 1; left: 141px; top: 131px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblAvailable" runat="server" height="19px" style="z-index: 1; left: 10px; top: 185px; position: absolute; right: 1419px" Text="Available" width="69px"></asp:Label>
        <asp:Label ID="lblSupplier" runat="server" height="19px" style="z-index: 1; left: 10px; top: 290px; position: absolute" Text="Supplier" width="69px"></asp:Label>
        <asp:TextBox ID="txtAvailable" runat="server" height="22px" style="z-index: 1; left: 141px; top: 182px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" height="19px" style="z-index: 1; left: 10px; top: 235px; position: absolute" Text="Price" width="69px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" height="22px" style="z-index: 1; left: 141px; top: 238px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplier" runat="server" height="22px" style="z-index: 1; left: 141px; top: 290px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 395px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
<%--           <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 457px; position: absolute" Text="OK" width="60px" />--%>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 457px; position: absolute" Text="Cancel" />
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 150px; top: 344px; position: absolute" Text="Active" />
        </p>
    </form>
</body>
</html>
