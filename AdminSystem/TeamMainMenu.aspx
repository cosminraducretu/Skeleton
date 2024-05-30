<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IPTV Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f0f0f0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        #form1 {
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            max-width: 600px;
            width: 90%;
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .form-title {
            font-family: 'Algerian', sans-serif;
            font-size: x-large;
            font-weight: bold;
            margin-bottom: 20px;
            text-align: center;
        }

        .form-buttons {
            display: flex;
            flex-direction: column;
            gap: 15px;
            width: 100%;
            max-width: 400px;
        }

        .form-buttons button {
            padding: 10px;
            border: none;
            border-radius: 4px;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
            transition: background-color 0.3s;
            width: 100%;
        }

        .form-buttons button:hover {
            background-color: #0056b3;
        }

        .form-buttons .cancel {
            background-color: #6c757d;
        }

        .form-buttons .cancel:hover {
            background-color: #5a6268;
        }

        .form-image {
            margin-top: 20px;
            display: flex;
            justify-content: center;
        }

        .form-image img {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-title">
            IPTV Main Menu
        </div>
        <div class="form-buttons">
            <asp:Button ID="btnStockMS" runat="server" OnClick="btnStockMS_Click" Text="Stock Management System" />
            <asp:Button ID="btnCMS" runat="server" OnClick="btnCMS_Click" Text="Customer Management System" />
            <asp:Button ID="btnSMS" runat="server" OnClick="btnSMS_Click" Text="Staff Management System" />
        </div>
        <div class="form-image">
            <img src="download.jpeg" alt="Image" />
        </div>
    </form>
</body>
</html>
