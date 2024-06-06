<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstUserList" runat="server" Style="z-index: 1; left: 12px; top: 15px; position: absolute; height: 542px; width: 556px"></asp:ListBox>
        </div>

        <div style="margin-left: 80px">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 21px; top: 581px; position: absolute" Text="Add" />
        </div>

        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 78px; top: 583px; position: absolute; height: 25px; width: 42px" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 624px; position: absolute; height: 22px; width: 48px" Text="lblError"></asp:Label>

    </form>
</body>
</html>
