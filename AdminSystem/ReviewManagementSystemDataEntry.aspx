<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 369px; width: 386px">
    <form id="form1" runat="server">
        <div style="height: 324px">
        </div>
        <asp:Label ID="UserId" runat="server" style="z-index: 1; left: 14px; position: absolute; bottom: 810px" Text="User Id"></asp:Label>
        <asp:TextBox ID="TxtUserId" runat="server" style="z-index: 1; left: 67px; top: 33px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 308px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 67px; top: 62px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="BookId" runat="server" style="z-index: 1; left: 15px; top: 72px; position: absolute; width: 46px; height: 24px" Text="Book Id"></asp:Label>
            <asp:Label ID="ReviewId" runat="server" style="z-index: 1; left: 15px; position: absolute; height: 22px; top: 107px; width: 46px" Text="Review Id"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 67px; top: 102px; position: absolute"></asp:TextBox>
        <asp:Label ID="RatingId" runat="server" style="z-index: 1; left: 15px; top: 138px; position: absolute; width: 46px; height: 21px" Text="Rating"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 67px; top: 133px; position: absolute"></asp:TextBox>
        <asp:Label ID="ReviewTextId" runat="server" style="z-index: 1; left: 15px; top: 169px; position: absolute" Text="Review Text" width="46px"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" style="z-index: 1; left: 67px; top: 167px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 16px; top: 209px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 256px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 309px; position: absolute" Text="OK" />
        <asp:Label ID="UserrId" runat="server" style="z-index: 1; left: 15px; top: 39px; position: absolute" Text="User Id"></asp:Label>
    </form>
</body>
</html>
