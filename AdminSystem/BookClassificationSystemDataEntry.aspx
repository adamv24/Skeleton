<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookClassificationSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
            <table>
                <tr>
                    <td><asp:Label ID="lblAuthorIdLabel" runat="server" Text="Author ID"></asp:Label></td>
                    <td><asp:TextBox ID="txtAuthorId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAuthorNameLabel" runat="server" Text="Author Name"></asp:Label></td>
                    <td><asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAuthorBiographyLabel" runat="server" Text="Biography"></asp:Label></td>
                    <td><asp:TextBox ID="txtAuthorBiography" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblDateJoinedLabel" runat="server" Text="Date Joined"></asp:Label></td>
                    <td><asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:CheckBox ID="chkIsBestseller" runat="server" Text="Is Bestseller" /></td>
                </tr>
            </table>
    
            <table>
                <tr>
                    <td><asp:Label ID="lblAverageRatingLabel" runat="server" Text="Average Rating"></asp:Label></td>
                    <td><asp:TextBox ID="txtAverageRating" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblTotalBooksSoldLabel" runat="server" Text="Total Books Sold"></asp:Label></td>
                    <td><asp:TextBox ID="txtTotalBooksSold" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        
        <div>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        </div>
    </form>
</body>
</html>