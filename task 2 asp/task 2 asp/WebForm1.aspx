<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task_2_asp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged">Result:</asp:TextBox> <br /><br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
           <asp:TextBox ID="Num1" runat="server" Text=""></asp:TextBox><br /> <br />
            <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label>
            <asp:TextBox ID="Num2" runat="server" Text=""></asp:TextBox><br /><br /> <br />
        <asp:Button ID="Button1" runat="server" Height="58px" OnClick="Button1_Click" Text="+" Width="137px" />
        <asp:Button ID="Button2" runat="server" Height="58px" OnClick="Button2_Click" style="margin-top: 0px" Text="-" Width="137px" />
        <asp:Button ID="Button3" runat="server" Height="58px" OnClick="Button3_Click" Text="*" Width="137px" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>