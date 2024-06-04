<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstUserList" runat="server" Style="z-index: 1; left: 12px; top: 14px; position: absolute; height: 549px; width: 564px"></asp:ListBox>
        </div>

        <div style="margin-left: 80px">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 580px; position: absolute" Text="Add" />
        </div>

    </form>
</body>
</html>
