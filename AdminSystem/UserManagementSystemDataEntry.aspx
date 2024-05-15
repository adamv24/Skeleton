<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtUserId" runat="server" height="25px" style="z-index: 1; left: 139px; top: 46px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblRoleName" runat="server" style="z-index: 1; left: 17px; top: 296px; position: absolute" Text="Role Name" width="77px"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 127px; position: absolute" Text="Name" width="77px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 12px; top: 160px; position: absolute; height: 20px" Text="Phone Number" width="77px"></asp:Label>
        <asp:Label ID="lblUserId" runat="server" style="z-index: 1; left: 14px; top: 50px; position: absolute" Text="User ID" width="77px"></asp:Label>
        <p>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 15px; top: 215px; position: absolute" Text="Address" width="77px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 277px; top: 373px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblRoleId" runat="server" style="z-index: 1; left: 15px; top: 88px; position: absolute" Text="Role ID" width="77px"></asp:Label>
        <p>
            <asp:Label ID="lblDateCreated" runat="server" style="z-index: 1; left: 17px; top: 248px; position: absolute; right: 1206px; height: 21px" Text="Date Created" width="77px"></asp:Label>
            <asp:TextBox ID="txtRoleName" runat="server" height="25px" style="z-index: 1; left: 139px; top: 289px; position: absolute; width: 168px"></asp:TextBox>
            <asp:TextBox ID="txtRoleId" runat="server" height="25px" style="z-index: 1; left: 139px; top: 83px; position: absolute" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNumber" runat="server" height="25px" style="z-index: 1; left: 139px; top: 156px; position: absolute" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server" height="25px" style="z-index: 1; left: 139px; top: 122px; position: absolute" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtDateCreated" runat="server" style="z-index: 1; left: 139px; top: 241px; position: absolute; width: 168px"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" height="25px" style="z-index: 1; left: 140px; top: 196px; position: absolute; width: 167px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 129px; top: 338px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 365px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 135px; top: 374px; position: absolute; width: 77px" Text="Ok" />
        </p>
    </form>
</body>
</html>
