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

       
    .btn {
        color: #fff;
        border: none;
        padding: 10px 20px;
        border-radius: 4px;
        cursor: pointer;
        margin: 0 5px;
        transition: background-color 0.3s;
    }
    .btn-yes{
        background-color: #1e90ff;
    }

    .btn-yes:hover {
        background-color: #0c7cd5;
    }
    .btn-no {
        background-color: #ff3300;
    }
    .btn-no:hover {
        background-color: #cc2900;
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
                <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" cssClass="btn btn-yes"/>
                <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" cssClass="btn btn-no" />
            </div>
        </div>
    </form>
</body>
</html>
