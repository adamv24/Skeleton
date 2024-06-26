﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management System Data Entry</title>
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
    .form-group {
        margin-bottom: 15px;
    }
    .form-group label {
        display: inline-block;
        margin-bottom: 5px;
        color: #1e90ff;
        
    }
    .form-group input {
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

    .form-actions .btn {
    background-color: #1e90ff;
    color: #fff;
    border: none;
    padding: 10px 20px;
    border-radius: 4px;
    cursor: pointer;
    margin: 0 5px;
    transition: background-color 0.3s;
    }

    .form-actions .btn:hover {
    background-color: #0c7cd5;
    }

    .form-actions .btn-cancel {
    background-color: #ff3300;
    }

    .form-actions .btn-cancel:hover {
    background-color: #cc2900;
    }

    .error-message {
        color: red;
        text-align: center;
    }

    .checkbox-group {
     display: flex;
     align-items: center;
    }

    .checkbox-group label {
    margin-right: 10px;
    }
</style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
                <label for="txtIsbnID">Isbn ID</label>
                <asp:TextBox ID="txtIsbnID" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtBookName">Book Name</label>
                <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtBookAuthor">Book Author</label>
                <asp:TextBox ID="txtBookAuthor" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPrice">Price</label>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDateAdded">Date Added</label>
                <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtQuantityAvailable">Quantity Available</label>
                <asp:TextBox ID="txtQuantityAvailable" runat="server"></asp:TextBox>
            </div>
            <div class="checkbox-group">
                <asp:CheckBox ID="chkIsAvailable" runat="server" Text="Is Available" />
            </div>

            <div class="error-message">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" CssClass="btn btn-ok" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn btn-cancel" />
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn btn-find"/>
            </div>
        </div>
    </form>
</body>
</html>
