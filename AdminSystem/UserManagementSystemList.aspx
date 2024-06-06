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
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 144px; top: 583px; position: absolute" Text="Delete" />
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 78px; top: 583px; position: absolute; height: 25px; width: 42px" Text="Edit" />
        </p>
       <p>
        <asp:Label ID="lblEnterBookName" runat="server" Text="Enter a Book Name   "></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
       </p>

        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
           
        
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" Text="Return to Main Menu" />
           
        
        <p>  <asp:Label ID="lblError" runat="server"></asp:Label></p>

    </form>
</body>
</html>
