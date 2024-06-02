<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management System</title>
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
    .confirmation-message {
        font-size: 18px;
        margin-bottom: 20px;
        text-align: center; 
    }
    .btn-container {
        text-align: center;
        margin-top: 20px; 
    }
   
</style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Delete Confirmation</h1>
            </div>
            <div class="confirmation-message">Are you sure you want to delete this record?</div>
            <div class="btn-container">
                <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" CssClass="btn" />
                <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" CssClass="btn" />
            </div>
        </div>
    </form>
</body>
</html>
