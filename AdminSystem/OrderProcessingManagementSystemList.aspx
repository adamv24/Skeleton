<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="573px" Width="563px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server"  Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </p>
       <p>
        <asp:Label ID="lblEnterOrderId" runat="server" Text="Enter an OrderId   "></asp:Label>
       </p>

        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" />
           
        
        <asp:Button ID="btnReturnToMainMenu" runat="server" Text="Return to Main Menu" />
           
        
        <p>  <asp:Label ID="lblError" runat="server"></asp:Label></p>

    </form>
</body>
</html>
