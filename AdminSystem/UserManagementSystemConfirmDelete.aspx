<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
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

        /* Container for the confirmation dialog */
        .confirm-container {
            background-color: #fff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
            text-align: center;
            max-width: 400px;
            width: 100%;
        }

        /* Styles for the confirmation text */
        .confirm-container div {
            font-size: 18px;
            margin-bottom: 20px;
        }

        /* Styles for the buttons */
        .confirm-container button {
            background-color: #dc3545;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
            margin: 0 10px;
        }

        /* Hover effect for Yes button */
        .confirm-container #btnYes:hover {
            background-color: #c82333;
        }

        /* Styles for the No button */
        .confirm-container #btnNo {
            background-color: #6c757d;
        }

        /* Hover effect for No button */
        .confirm-container #btnNo:hover {
            background-color: #5a6268;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Container for the confirmation dialog -->
        <div class="confirm-container">
            <!-- Confirmation text -->
            <div>Are you sure you want to delete this record?</div>

            <!-- Buttons for Yes and No actions -->
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" CssClass="button" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" CssClass="button" />
        </div>
    </form>
</body>
</html>
