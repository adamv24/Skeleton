<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblIsbnID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; bottom: 604px;" Text="Isbn ID" width="42px"></asp:Label>
            <asp:TextBox ID="txtIsbnID" runat="server" style="z-index: 1; left: 104px; top: 66px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblBookName" runat="server" style="z-index: 1; left: 8px; top: 97px; position: absolute" Text="Book Name" width="42px"></asp:Label>
            <asp:TextBox ID="txtBookName" runat="server" style="z-index: 1; left: 104px; top: 110px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblBookAuthor" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute; right: 402px" Text="Book Author" width="42px"></asp:Label>
            <asp:TextBox ID="txtBookAuthor" runat="server" style="z-index: 1; left: 104px; top: 153px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 13px; top: 194px; position: absolute; right: 411px" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; top: 192px; position: absolute; left: 104px;" width="128px"></asp:TextBox>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 8px; top: 235px; position: absolute; right: 398px" Text="Date Added" width="42px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; top: 242px; position: absolute; left: 104px;" width="128px"></asp:TextBox>
            <asp:Label ID="lblQuantityAvailable" runat="server" style="z-index: 1; left: 10px; top: 280px; position: absolute; right: 393px" Text="Quantity Available" width="42px"></asp:Label>
            <asp:TextBox ID="txtQuantityAvailable" runat="server" style="z-index: 1; top: 288px; position: absolute; left: 104px;" width="128px"></asp:TextBox>
            <asp:CheckBox ID="chkIsAvailable" runat="server" style="z-index: 1; left: 10px; top: 330px; position: absolute" Text="Is Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 360px; position: absolute" Text=""></asp:Label>
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 50px; top: 390px; position: absolute" Text="Ok" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 100px; top: 390px; position: absolute" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 280px; top: 65px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        </div>
    </form>
</body>
</html>
