<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Management System</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f0f8ff;
            color: #333;
        }
        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            text-align: center;
            margin-bottom: 20px;
        }
        .header h1 {
            color: #1e90ff;
            font-size: 24px;
            margin-top: 0;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group input, .form-group select, .form-group textarea {
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
        .form-actions .btn {
            background-color: #007bff;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-decoration: none;
            margin: 5px;
        }
        .form-actions .btn:hover {
            background-color: #0056b3;
        }
        .form-actions .btn-delete {
            background-color: #ff3300;
        }
        .form-actions .btn-delete:hover {
            background-color: #cc2900;
        }
        .btn-return {
            background-color: #28a745;
        }
        .btn-return:hover {
            background-color: #218838;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Container for the user management system -->
        <div class="container">
            <div class="header">
                <h1>User Management System</h1>
            </div>
            <!-- User ListBox -->
            <div class="form-group">
                <asp:ListBox ID="lstUserList" runat="server" CssClass="user-list"></asp:ListBox>
            </div>
            <!-- Buttons for Add, Edit, and Delete -->
            <div class="form-actions">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="btn" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" CssClass="btn" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn btn-delete" />
            </div>
            <!-- Filter Section -->
            <div class="form-group">
                <asp:Label ID="lblEnterName" runat="server" Text="Enter a Name" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" CssClass="btn" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" CssClass="btn" />
            </div>
            <!-- Return to Main Menu button -->
            <div class="form-actions">
                <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" Text="Return to Main Menu" CssClass="btn btn-return" />
            </div>
            <!-- Error message label -->
            <div class="error-message">
                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
