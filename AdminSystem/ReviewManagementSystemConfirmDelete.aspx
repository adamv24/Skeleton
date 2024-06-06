<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 36px; top: 154px; position: absolute; width: 71px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 183px; top: 152px; position: absolute; width: 71px" Text="No" />
        <asp:Label ID="lblDelRec" runat="server" style="z-index: 1; left: 24px; top: 85px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
