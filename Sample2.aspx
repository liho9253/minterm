<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample2.aspx.cs" Inherits="minterm.Sample2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>訂貨系統</h2>
            <asp:DropDownList ID="ddl_Area" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Area_SelectedIndexChanged">
            </asp:DropDownList>
            <br/>
            <asp:DropDownList ID="ddl_Place" runat="server"></asp:DropDownList>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
            <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="其他"></asp:Label>
            <br />
            <asp:RadioButtonList ID="rbl_Res" runat="server" AutoPostBack="True">
                <asp:ListItem Selected="True" Value="Rad_No">否</asp:ListItem>
                <asp:ListItem Value="Rad_Yes">是</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="tb_Des" runat="server" Width="400px" Visible="False"></asp:TextBox>
            <br/>
            <asp:Button ID="btn_Sub" runat="server" Text="送出" OnClick="btn_Sub_Click" />
            <br />
            <asp:Label ID="lb_Msg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
