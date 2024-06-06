<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewBookLogin.aspx.cs" Inherits="ReviewBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background: #f0f8ff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblRevBook" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Review Book Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 28px; top: 111px; position: absolute" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 115px; top: 146px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 111px; top: 110px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 111px; top: 110px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 301px; top: 123px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 33px; top: 144px; position: absolute" Text="Password:"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 63px; top: 194px; position: absolute" Text="Login" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 189px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
