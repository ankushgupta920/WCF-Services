<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Product ID:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Record" />
        <br />
        <br />
        <br />
        Product Details:<br />
        <asp:GridView ID="GridView1" runat="server" Height="185px" Width="353px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
