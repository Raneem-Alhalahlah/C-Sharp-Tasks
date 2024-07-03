<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />

              <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />


              <asp:Label ID="Label3" runat="server" Text="ID"></asp:Label>
              <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />


            <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" />

             <asp:RadioButton ID="RadioButton2" runat="server" />







        </div>
    </form>
</body>
</html>
