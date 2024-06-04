<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainReview" runat="server" Font-Size="X-Large" style="z-index: 1; left: 148px; top: 87px; position: absolute; height: 22px" Text="Review Book Main Menu"></asp:Label>
        <asp:Button ID="btnStockManagement" runat="server" OnClick="btnStockManagement_Click" style="z-index: 1; left: 215px; top: 170px; position: absolute" Text="Stock Management" />
        <p>
            <asp:Button ID="btnBookClassification" runat="server" style="z-index: 1; left: 318px; top: 215px; position: absolute" Text="Book Classification" />
        </p>
        <p>
            <asp:Button ID="btnUserManagement" runat="server" style="z-index: 1; top: 173px; position: absolute; left: 405px" Text="User Management" />
        </p>
        <p>
            <asp:Button ID="btnOrderProcessing" runat="server" style="z-index: 1; left: 128px; top: 213px; position: absolute" Text="Order Processing" />
        </p>
        <p>
            <asp:Button ID="btnBookReviews" runat="server" OnClick="btnBookReviews_Click" style="z-index: 1; left: 79px; top: 169px; position: absolute" Text="Book Reviews" />
        </p>
    </form>
</body>
</html>
