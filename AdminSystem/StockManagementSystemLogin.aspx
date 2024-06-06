<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemLogin.aspx.cs" Inherits="StockManagementSystemLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management System Login</title>
     <style>
     body {
         font-family: Arial, sans-serif;
         margin: 20px;
         background-color: #f0f8ff;
         color: #333;
     }
     .container {
         max-width: 400px;
         margin: 0 auto;
         padding: 20px;
         background-color: #fff;
         border-radius: 8px;
     }
     .header {
         text-align: center;
         margin-bottom: 20px;
     }
     .header h1 {
         color: #1e90ff;
     }

     .form-group {
         margin-bottom: 15px;
     }
     
     .form-group input{
         display: block;
         width: 100%;
         padding: 8px;
         box-sizing: border-box;
         border: 1px solid #ddd;
         border-radius: 4px;
     }
     .form-actions {
         text-align: center;
         margin: 20px 0;
     }
     
     .error-message {
         color: #ff3300;
         text-align: center;
     }

     .form-actions .btn-login {
        background-color: #1e90ff;
        color: #fff;
        border: none;
        padding: 10px 20px;
        border-radius: 4px;
        cursor: pointer;
        transition: background-color 0.3s;
    }
    .form-actions .btn-login:hover {
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

     
 </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Stock Management System Login</h1>
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
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" cssClass ="btn btn-login"/>
                <asp:Button ID="lblCancel" runat="server" Text="Cancel" OnClick="lblCancel_Click" CssClass ="btn btn-cancel" />
            </div>
        </div>
    </form>
</body>
</html>
