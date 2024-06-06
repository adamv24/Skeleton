<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookClassificationSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Classification System</title>
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
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
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
        background-color: #1e90ff;
        color: #fff;
        border: none;
        padding: 10px 20px;
        border-radius: 4px;
        cursor: pointer;
        margin: 0 5px;
        transition: background-color 0.3s;
    }
    .btn:hover {
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
                <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="btn" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn btn-no" OnClick="btnNo_Click"  />
            </div>
        </div>
    </form>
</body>
</html>
