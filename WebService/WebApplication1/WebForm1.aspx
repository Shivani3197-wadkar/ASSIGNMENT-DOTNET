<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        EMPLOYEE NO<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        EMPLOYEE NAME<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        SALARY<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        DEPTNO
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INSERT" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="DELETE" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="UPDATE" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="SHOW ALL" />
    
    </div>
    </form>
</body>
</html>
