<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Management System</title>
    <style>
        /* Basic styles for the body to center the form and set background color */
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        /* Container for the user management system */
        .user-container {
            background-color: #fff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
            text-align: center;
            max-width: 600px;
            width: 100%;
        }

        /* Header styles */
        .user-container h1 {
            margin-top: 0;
            color: #333;
            font-size: 24px;
            margin-bottom: 20px;
        }

        /* Style for ListBox */
        .user-container .user-list {
            width: 100%;
            height: 400px;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            padding: 10px;
        }

        /* Styles for the input fields */
        .user-container input[type="text"] {
            width: calc(100% - 22px);
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        /* Style for buttons */
        .user-container .button {
            background-color: #007bff;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
            margin: 5px;
        }

        /* Hover effect for buttons */
        .user-container .button:hover {
            background-color: #0056b3;
        }

        /* Error message style */
        .user-container .error {
            color: #FF3300;
            margin-top: 10px;
        }

        /* Label styles */
        .user-container .label {
            display: block;
            margin-bottom: 5px;
            color: #333;
        }

        /* Additional button styles */
        .user-container .btn-return {
            margin-top: 20px;
            background-color: #28a745;
        }

        /* Hover effect for return button */
        .user-container .btn-return:hover {
            background-color: #218838;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Container for the user management system -->
        <div class="user-container">
            <h1>User Management System</h1>

            <!-- User ListBox -->
            <asp:ListBox ID="lstUserList" runat="server" CssClass="user-list"></asp:ListBox>

            <!-- Buttons for Add, Edit, and Delete -->
            <p>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="button" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" CssClass="button" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="button" />
            </p>

            <!-- Filter Section -->
            <p>
                <asp:Label ID="lblEnterName" runat="server" Text="Enter a Name" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" CssClass="button" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" CssClass="button" />
            </p>

            <!-- Return to Main Menu button -->
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" Text="Return to Main Menu" CssClass="button btn-return" />

            <!-- Error message label -->
            <p><asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label></p>
        </div>
    </form>
</body>
</html>
