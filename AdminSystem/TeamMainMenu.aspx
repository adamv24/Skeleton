<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f8ff;
            color: #333;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background-color: #fff;
            padding: 20px 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            width: 100%;
            text-align: center;
        }
        h3 {
            color: #1e90ff;
            margin-bottom: 20px;
        }
        .btn {
            background-color: #1e90ff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 4px;
            cursor: pointer;
            margin: 10px 0;
            width: 100%;
            transition: background-color 0.3s;
        }
        .btn:hover {
            background-color: #0c7cd5;
        }
        .btn-cancel {
            background-color: #ff3300;
        }
        .btn-cancel:hover {
            background-color: #cc2900;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h3>ATC Book Store Main Menu</h3>
            <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" Text="Stock" CssClass="btn" />
            <asp:Button ID="btnUser" runat="server" Text="User" OnClick="btnUser_Click" CssClass="btn" />
            <asp:Button ID="btnReview" runat="server" Text="Review" OnClick="btnReview_Click" CssClass="btn" />
            <asp:Button ID="btnOrderProcessing" runat="server" Text="Order Processing" OnClick="btnOrderProcessing_Click" CssClass="btn" />
            <asp:Button ID="btnBookClassification" runat="server" Text="Book Classification" OnClick="btnBookClassification_Click" CssClass="btn" />
        </div>
    </form>
</body>
</html>


