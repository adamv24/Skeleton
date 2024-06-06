<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Processing Management System - Data Entry</title>
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
        fieldset {
            border: none;
            padding: 0;
        }
        legend {
            font-size: 1.2em;
            margin-bottom: 10px;
            color: #1e90ff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Order Processing Management System - Data Entry</h1>
            </div>
            <fieldset>
                <legend>Order Information</legend>
                <div class="form-group">
                    <asp:Label ID="lblOrderId" runat="server" Text="Order Id"></asp:Label>
                    <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblISBN" runat="server" Text="ISBN" AssociatedControlID="txtISBN"></asp:Label>
                    <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblUserId" runat="server" Text="User Id" AssociatedControlID="txtUserId"></asp:Label>
                    <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCreatedAt" runat="server" Text="Created At" AssociatedControlID="txtCreatedAt"></asp:Label>
                    <asp:TextBox ID="txtCreatedAt" runat="server"></asp:TextBox>
                </div>
               
                 <div class="checkbox-group">
     <asp:CheckBox ID="chkIsAvailable" runat="server" Text="Is Available" />
 </div>
                
                <div class="form-group">
                    <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
                    <div class="form-actions">
                        <asp:Button ID="Button3" runat="server" OnClick="btnFind_Click" CssClass="btn" Text="Find" />
                    
                    </div>
                     <div class="form-actions">
                     <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    </div>

                </div>
                <!-- Status Section -->
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Status"></asp:Label>
                    <asp:Label ID="lblStatusValue" runat="server"></asp:Label>
                </div>
            </fieldset>
            <div class="form-actions">
                <asp:Button ID="Button4" runat="server" OnClick="btnOk_Click" CssClass="btn" Text="OK" />
            </div>
        </div>
    </form>
</body>
</html>
