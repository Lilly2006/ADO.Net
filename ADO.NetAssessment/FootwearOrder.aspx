<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FootwearOrder.aspx.cs" Inherits="OnlineFootWearStore.FootwearOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Product_Code"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblProductcode" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Product_Name"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblProductname" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Cost"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblcost" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCost" runat="server" Text="Display Cost" OnClick="btnCost_Click"  /></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Total Amount : "></asp:Label>
            <asp:Label ID="lblTotal_Amount" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnPayment" runat="server" Text="Payment" OnClick="btnPayment_Click" />
        </div>
        
    </form>
</body>
</html>
