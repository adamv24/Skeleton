<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 392px; position: absolute" Text="Add" />
        <asp:ListBox ID="lstReviewList" runat="server" style="z-index: 1; left: 15px; top: 31px; position: absolute; height: 343px; width: 356px" OnSelectedIndexChanged="lstReviewList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 80px; top: 392px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 156px; top: 392px; position: absolute" Text="Delete" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 546px; position: absolute; height: 19px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
            <asp:Label ID="lblTextHere" runat="server" style="z-index: 1; left: 22px; top: 446px; position: absolute" Text="Enter Text Here"></asp:Label>
        <asp:TextBox ID="txtTextIdHere" runat="server" style="z-index: 1; top: 445px; position: absolute; left: 142px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 30px; top: 489px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 158px; top: 490px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 307px; top: 488px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
