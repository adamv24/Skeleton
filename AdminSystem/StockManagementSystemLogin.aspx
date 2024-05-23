<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemLogin.aspx.cs" Inherits="StockManagementSystemLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p>Are you sure you want to delete this record?</p>

        </div>
        <asp:Label ID="lblUserName" runat="server" Text="UserName   "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password   "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <asp:Button ID="lblCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
