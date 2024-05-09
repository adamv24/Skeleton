<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookClassificationSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Author Information</legend>
            <div>
                <asp:Label ID="lblAuthorId" runat="server" Text="Author ID" AssociatedControlID="txtAuthorId"></asp:Label>
                <asp:TextBox ID="txtAuthorId" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblAuthorName" runat="server" Text="Author Name" AssociatedControlID="txtAuthorName"></asp:Label>
                <asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox>
            </div>
        <div>
        </div>
    </form>
</body>
</html>