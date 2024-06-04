<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemList.aspx.cs" Inherits="_1_List" %>

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
         max-width: 600px;
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

     .form-group input, .form-group button, .form-group .asp-listbox {
         display: block;
         width: 100%;
         padding: 8px;
         box-sizing: border-box;
         border: 1px solid #ddd;
         border-radius: 4px;
     }
     .form-actions {
         text-align: center;
         margin: 10px 0;
     }
     .form-actions button {
         margin: 0 5px;
         padding: 10px 20px;
         color: white;
         border: none;
         border-radius: 4px;
     }
     .form-actions button:hover {
         background-color: #1c86ee;
     }
     .error-message {
         color: red;
         text-align: center;
     }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Stock Management System</h1>
            </div>
            <div class="form-group">
                <asp:ListBox ID="lstStockList" runat="server" CssClass="asp-listbox" Height="573px"></asp:ListBox>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add"  />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit"  />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete"  />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEnterBookName" runat="server" Text="Enter a Book Name:" AssociatedControlID="txtFilter"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
            </div>
            <div class="form-actions">
                <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" Text="Return to Main Menu" />
            </div>
            <div class="error-message">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
            </div>
    </form>
</body>
</html>
