<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleMember.aspx.cs" Inherits="minterm.SampleMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>會員註冊</h2>
            <p class="Font-Size:X-Large">會員帳號
            <asp:TextBox ID="tb_Acc" runat="server" Width="200px" Height="15px"></asp:TextBox></p>
            <p class="Font-Size:X-Large">密碼
            <asp:TextBox ID="tb_Pass" runat="server" Width="200px" Height="15px" TextMode="Password"></asp:TextBox></p>

            <p class="Font-Size:X-Large"> 興趣
               <asp:CheckBox ID="CheckBox1" runat="server" Text="看書" ValidationGroup="sex" />
               <asp:CheckBox ID="CheckBox2" runat="server" Text="打電動" ValidationGroup="sex" />
               <asp:CheckBox ID="CheckBox3" runat="server" Text="其他" ValidationGroup="sex"/>
            </p>
            <p class="Font-Size:X-Large">其他連結
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://aws.amazon.com/tw/ " ImageUrl="aws.png"></asp:HyperLink></p>
            <asp:Button ID="bt_Next" runat="server" Text="送出" Width="80px" Height="30px" PostBackUrl="~/Sample1Com.aspx"/>
        </div>
    </form>
</body>
</html>
