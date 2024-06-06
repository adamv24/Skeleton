<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookClassificationSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Classification System - Author Entry</title>
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
            max-width: 600px;
            width: 100%;
        }
        h1 {
            text-align: center;
            color: #1e90ff;
            margin-bottom: 20px;
        }
        table {
            width: 100%;
            margin-bottom: 20px;
            border-spacing: 0;
            border-collapse: collapse;
        }
        td {
            padding: 10px;
            vertical-align: middle; /* Centering the labels vertically */
        }
        input[type="text"], textarea {
            width: 100%;
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 4px;
            box-sizing: border-box;
            margin-top: 5px;
        }
        input[type="text"]:focus, textarea:focus {
            border-color: #1e90ff;
            outline: none;
        }
        .form-actions {
            text-align: center;
            margin-top: 20px;
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
            text-align: center;
            color: red;
            margin-bottom: 20px;
        }
        .btn-main-menu {
            display: block;
            margin: 20px auto 0; /* Centering horizontally */
            width: fit-content;
        }
        .auto-style1 {
            width: 127px;
        }
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style3 {
            width: 241px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Author Entry</h1>
            <table>
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblAuthorIdLabel" runat="server" Text="Author ID"></asp:Label></td>
                    <td><asp:TextBox ID="txtAuthorId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblAuthorNameLabel" runat="server" Text="Author Name"></asp:Label></td>
                    <td><asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblAuthorBiographyLabel" runat="server" Text="Biography"></asp:Label></td>
                    <td><asp:TextBox ID="txtAuthorBiography" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblDateJoinedLabel" runat="server" Text="Date Joined"></asp:Label></td>
                    <td><asp:TextBox ID="txtDateJoined" runat="server" CssClass="auto-style2"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:CheckBox ID="chkIsBestseller" runat="server" Text="Is Bestseller" /></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style3"><asp:Label ID="lblAverageRatingLabel" runat="server" Text="Average Rating"></asp:Label></td>
                    <td><asp:TextBox ID="txtAverageRating" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3"><asp:Label ID="lblTotalBooksSoldLabel" runat="server" Text="Total Books Sold"></asp:Label></td>
                    <td><asp:TextBox ID="txtTotalBooksSold" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <div class="error-message">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>
            <div class="form-actions">
                <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" CssClass="btn" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-cancel" />
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn" />
            </div>
            <div class="form-actions">
                <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" CssClass="btn btn-main-menu" style="margin-left: 0px" Width="600px" />
            </div>
        </div>
    </form>
</body>
</html>





