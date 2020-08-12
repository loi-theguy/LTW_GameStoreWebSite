<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="LoginControl" %>
<h1>Log In</h1>
<table>
    <tr>
        <td>
            Username
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Password
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
            <a href="#">Forgot your password?</a>
        </td>
    </tr>
</table>
<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<script>
    function baoLoi() {
        alert("Tài khoản không tồn tại!");
    }
</script>
