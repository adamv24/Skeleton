<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>User Management System Login</title>
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

     
 </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Login</h1>
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
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" cssClass ="btn"/>
                <asp:Button ID="lblCancel" runat="server" Text="Cancel" OnClick="lblCancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>