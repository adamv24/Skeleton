<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Order Information<asp:Button ID="Button1" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 380px; top: 86px; position: absolute; height: 29px; width: 123px; bottom: 759px;" Text="Find" />
            </legend>
            <div>
                <asp:Label ID="lblOrderId" runat="server" Text="Order Id"></asp:Label>
                <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
                </div>
            <div>
                <asp:Label ID="lblISBN" runat="server" Text="ISBN" AssociatedControlID="txtISBN"></asp:Label>
                <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblUserId" runat="server" Text="User Id" AssociatedControlID="txtUserId"></asp:Label>
                <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
            </div>
            <!-- Status Section -->
            <div>
                <asp:Label ID="Label1" runat="server" Text="Status"></asp:Label>
                <asp:Label ID="lblStatusValue" runat="server"></asp:Label>
            </div>
        </fieldset>
    </form>
</body>
</html>
