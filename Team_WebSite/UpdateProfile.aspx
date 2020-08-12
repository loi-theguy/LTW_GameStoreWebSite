<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Mật khẩu cũ"></asp:Label><br />
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Không bỏ trống ô!" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Mật khẩu mới"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Không bỏ trống ô!" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Đổi mật khẩu" OnClick="Button1_Click" />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
</asp:Content>

