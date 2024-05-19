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
        <asp:TextBox ID="txtQuantity" runat="server" height="22px" style="z-index: 1; left: 141px; top: 80px; position: absolute; bottom: 568px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 10px; top: 133px; position: absolute; bottom: 524px" Text="Description"></asp:Label>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" height="22px" style="z-index: 1; left: 141px; top: 131px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplier" runat="server" height="19px" style="z-index: 1; left: 10px; top: 246px; position: absolute" Text="Supplier" width="69px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" height="19px" style="z-index: 1; left: 10px; top: 190px; position: absolute" Text="Price" width="69px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" height="22px" style="z-index: 1; left: 141px; top: 186px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplier" runat="server" height="22px" style="z-index: 1; left: 141px; top: 241px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 337px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 415px; position: absolute" Text="OK" width="60px" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 415px; position: absolute" Text="Cancel" />
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 150px; top: 301px; position: absolute" Text="Active" />
        </p>
    </form>
</body>
</html>
