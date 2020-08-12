<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="DeleteUsers.aspx.cs" Inherits="DeleteUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Danh sách tất cả các tài khoản người dùng </h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="bang">
        <Columns>
            <asp:BoundField DataField="userid" HeaderText="Mã Tài Khoản"></asp:BoundField>
            <asp:BoundField DataField="username" HeaderText="Tên tài khoản"></asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href='<%#"DeleteUsers.aspx?xoa="+Eval("userid") %>'>Xóa</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <script>
            function baoLoi() {
                alert("Không thể xóa người dùng này bởi vì họ đã từng thực hiện giao dịch");
            }
    </script>
</asp:Content>

