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
        <asp:Button ID="btnUser" runat="server" Text="User" />
        <asp:Button ID="btnReview" runat="server" Text="Review" />
        <asp:Button ID="btnOrderProcessing" runat="server" Text="Order Processing" />
        <asp:Button ID="btnBookClassification" runat="server" Text="Book Classification" />      
        </div>
    </form>
</body>
</html>
