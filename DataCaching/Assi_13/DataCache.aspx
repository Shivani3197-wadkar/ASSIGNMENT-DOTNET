<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataCache.aspx.cs" Inherits="Assi_13.DataCache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Emp_No:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Emp_Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            salary:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cache Data" />
&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Clear Cache" />
            <br />
&nbsp;<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Emp_No" DataSourceID="SqlDataSource1" Height="163px" Visible="False" Width="222px">
                <Columns>
                    <asp:BoundField DataField="Emp_No" HeaderText="Emp_No" ReadOnly="True" SortExpression="Emp_No" />
                    <asp:BoundField DataField="Emp_Name" HeaderText="Emp_Name" SortExpression="Emp_Name" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [employee]"></asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
