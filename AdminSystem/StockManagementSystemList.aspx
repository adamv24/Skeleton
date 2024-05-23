<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="573px" Width="563px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
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
