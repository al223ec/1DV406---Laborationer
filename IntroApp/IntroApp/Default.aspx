<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntroApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="op1" runat="server"></asp:TextBox> +
        <asp:TextBox ID="op2" runat="server"></asp:TextBox>
        <asp:Button ID="submit" runat="server" Text="ok" OnClick="submit_Click" />
        <asp:Label ID="result" runat="server" Text="result"></asp:Label>
    </div>
    </form>
</body>
</html>
