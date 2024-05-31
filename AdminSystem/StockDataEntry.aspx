<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 267px;
        }
        .auto-style13 {
            z-index: 1;
            left: 249px;
            top: 404px;
            position: absolute;
            width: 65px;
        }
        .auto-style12 {
            z-index: 1;
            left: 34px;
            top: 404px;
            position: absolute;
            width: 71px;
            right: 709px;
        }
        .auto-style14 {
            z-index: 1;
            left: 146px;
            top: 406px;
            position: absolute;
        }
        </style>
</head>
<body style="height: 363px">
    <form id="form1" runat="server">
        <div style="height: 35px">
        </div>
        <asp:Label ID="lblStockId" runat="server" height="19px" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Stock ID" width="69px"></asp:Label>
        <asp:TextBox ID="txtStockid" runat="server" height="22px" style="z-index: 1; left: 141px; top: 34px; position: absolute; bottom: 614px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" height="19px" style="z-index: 1; left: 10px; top: 78px; position: absolute" Text="Quantity" width="69px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" height="22px" style="z-index: 1; left: 141px; top: 80px; position: absolute; bottom: 568px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 10px; top: 133px; position: absolute; bottom: 524px" Text="Description"></asp:Label>
        <p style="height: 34px">
            <asp:TextBox ID="txtDescription" runat="server" height="22px" style="z-index: 1; left: 141px; top: 131px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplier" runat="server" height="19px" style="z-index: 1; left: 10px; top: 246px; position: absolute" Text="Supplier" width="69px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" height="19px" style="z-index: 1; left: 10px; top: 190px; position: absolute" Text="Price" width="69px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" height="22px" style="z-index: 1; left: 141px; top: 186px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplier" runat="server" height="22px" style="z-index: 1; left: 141px; top: 241px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 150px; top: 294px; position: absolute" Text="Active" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 219px; top: 328px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style13" Text="Cancel" height="29px" TabIndex="9" OnClick="btnCancel_Click1" />
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style12" height="29px" OnClick="btnOK_Click" Text="OK" width="68px" TabIndex="6" />
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style14" height="29px" OnClick="btnFind_Click" TabIndex="7" Text="Find" width="68px" />
        <asp:Button ID="btnRTN" runat="server" height="29px" OnClick="btnRTN_Click" style="z-index: 1; left: 346px; top: 407px; position: absolute; width: 147px" Text="Return to MainMenu" />
    </form>
</body>
</html>
