<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 442px;
            width: 705px;
        }
    </style>
</head>
<body style="height: 367px; width: 528px">
    
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 17px; position: absolute; height: 28px; width: 56px; right: 668px;" Text="User Id"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 13px; top: 205px; position: absolute" Text="Review Text" height="21px"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 8px; top: 112px; position: absolute" Text="Review Id" height="21px"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 12px; top: 68px; position: absolute; height: 21px" Text="Book Id"></asp:Label>
        <asp:TextBox ID="txtBookId" runat="server" style="z-index: 1; left: 83px; top: 67px; position: absolute; height: 19px;"></asp:TextBox>
        <asp:TextBox ID="txtReviewTextId" runat="server" style="z-index: 1; left: 101px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtReviewId" runat="server" style="z-index: 1; left: 83px; top: 112px; position: absolute; width: 128px;"></asp:TextBox>
        <asp:TextBox ID="txtRatingId" runat="server" style="z-index: 1; left: 83px; top: 160px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAddedId" runat="server" style="z-index: 1; left: 115px; top: 239px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUser" runat="server" style="z-index: 1; left: 83px; top: 21px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 20px; top: 160px; position: absolute; height: 28px; width: 51px" Text="Rating"></asp:Label>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 116px; top: 304px; position: absolute" Text="Cancel" />
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 22px; top: 235px; position: absolute" Text="Date Added:"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 272px; top: 28px; position: absolute" Text="Find" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 32px; top: 305px; position: absolute; height: 26px;" Text="OK" width="60px" />
        <asp:CheckBox ID="txtCheck" runat="server" style="z-index: 1; left: 55px; top: 266px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 147px; top: 272px; position: absolute"></asp:Label>
    </form>
    
    </body>
</html>
