

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        /* Basic styling for the form elements */
        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            height: 100vh;
            padding: 20px;
            box-sizing: border-box;
        }

        .message {
            margin-bottom: 20px;
            font-size: 1.2em;
            text-align: center;
        }

        .button-group {
            display: flex;
            gap: 10px;
        }

        .button-group button {
            padding: 10px 20px;
            font-size: 1em;
        }

        /* Media query for smaller screens */
        @media (max-width: 600px) {
            .message {
                font-size: 1em;
            }

            .button-group button {
                font-size: 0.9em;
                padding: 8px 16px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblAreYou" runat="server" CssClass="message" Text="Are you sure you wanna delete this record?"></asp:Label>
            <div class="button-group">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" CssClass="btn" Text="Yes" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" CssClass="btn" Text="No" />
            </div>
        </div>
    </form>
</body>
</html>


