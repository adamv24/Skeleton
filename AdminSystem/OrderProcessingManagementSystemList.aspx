<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Processing Management System</title>
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
            background-color: #1e90ff;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-decoration: none;
        }
        .form-actions .btn:hover {
            background-color: #1c86ee;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Order Processing Management System</h1>
            </div>
            <div class="form-group">
                <asp:ListBox ID="lstOrderList" runat="server" Height="573px" Width="563px"></asp:ListBox>
          
            </div>
            <div class="form-actions">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="btn" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" CssClass="btn" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEnterBookName" runat="server" Text="Enter status"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btn" OnClick="btnApplyFilter_Click" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="btn" OnClick="btnClearFilter_Click1" />
                <asp:Button ID="btnReturnToMainMenu" OnClick ="btnReturnToMainMenu_Click" runat="server" Text="Return to Main Menu" CssClass="btn" />
            </div>
            <div class="error-message">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
