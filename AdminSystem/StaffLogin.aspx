<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            font-family: Arial, sans-serif;
        }
        .login-container {
            position: relative;
            width: 100%;
            max-width: 400px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            background-color: #fff;
        }
        .form-label, .form-input {
            display: block;
            width: 100%;
            margin-bottom: 15px;
        }
        .form-input {
            padding: 8px;
            box-sizing: border-box;
        }
        .form-buttons {
            display: flex;
            justify-content: space-between;
        }
        .form-button {
            width: 48%;
            padding: 10px;
            box-sizing: border-box;
            cursor: pointer;
        }
        .error-message {
            color: #FF3300;
            margin-top: -10px;
            display: block;
            text-align: center;
        }
        @media (max-width: 768px) {
            .login-container {
                padding: 15px;
            }
        }
        @media (max-width: 480px) {
            .login-container {
                padding: 10px;
            }
            .form-button {
                margin-bottom: 10px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <asp:Label ID="lblLogin" runat="server" Text="LOGIN PAGE" CssClass="form-label" style="text-align: center; font-size: 24px; margin-bottom: 20px;"></asp:Label>
            <asp:Label ID="lblUserName" runat="server" Text="UserName:" CssClass="form-label" style="margin-top: 15px;"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" CssClass="form-input"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Password:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-input"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>
            <div class="form-buttons">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="form-button" OnClick="btnLogin_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="form-button" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>
