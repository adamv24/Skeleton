<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookClassificationSystemLogin.aspx.cs" Inherits="BookClassificationLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Classification System Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f0f8ff;
            color: #333;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .container {
            max-width: 400px;
            width: 100%;
            padding: 30px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .header {
            margin-bottom: 20px;
        }
        .header h1 {
            color: #1e90ff;
            font-size: 24px;
            margin: 0;
        }
        .form-group {
            margin-bottom: 20px;
            text-align: left;
        }
        .form-group input {
            width: 100%;
            padding: 10px;
            margin-top: 5px;
            box-sizing: border-box;
            border: 1px solid #ddd;
            border-radius: 4px;
            transition: border-color 0.3s;
        }
        .form-group input:focus {
            border-color: #1e90ff;
            outline: none;
        }
        .form-actions {
            margin-top: 20px;
        }
        .form-actions .btn {
            background-color: #1e90ff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }
        .form-actions .btn:hover {
            background-color: #0c7cd5;
        }
        .form-actions .btn-cancel {
            background-color: #ff3300;
            margin-left: 10px;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }
        .form-actions .btn-cancel:hover {
            background-color: #cc2900;
        }
        .error-message {
            color: #ff3300;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Book Classifcation System Login</h1>
            </div>
            <div class="form-group">
                <asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="error-message">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" cssClass="btn" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" cssClass="btn btn-cancel" />
            </div>
        </div>
    </form>
</body>
</html>