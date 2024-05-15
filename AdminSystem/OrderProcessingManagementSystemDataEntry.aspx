<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Order Information</legend>
            <div>
                <asp:Label ID="lblItemId" runat="server" Text="Item Id" AssociatedControlID="txtAuthorId"></asp:Label>
                <asp:TextBox ID="txtItemId" runat="server" OnTextChanged="txtItemId_TextChanged"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblItemName" runat="server" Text="Item Name" AssociatedControlID="txtItemName"></asp:Label>
            </div>
        <div>
        </div>
    </form>
</body>
</html>
