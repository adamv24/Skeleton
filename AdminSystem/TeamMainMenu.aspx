<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h3>Book Main Menu</h3>
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" Text="Stock" />
        <asp:Button ID="btnUser" runat="server" Text="User" OnClick="btnUser_Click" />
        <asp:Button ID="btnReview" runat="server" Text="Review" OnClick="btnReview_Click" />
        <asp:Button ID="btnOrderProcessing" runat="server" Text="Order Processing" OnClick="btnOrderProcessing_Click" />
        <asp:Button ID="btnBookClassification" runat="server" Text="Book Classification" OnClick="btnBookClassification_Click" />      
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
