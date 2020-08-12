<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1> Mã hóa đơn: <asp:Label ID="Label2" runat="server" Text=""></asp:Label>  </h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="bang">
        <Columns>
            <asp:BoundField DataField="magame" HeaderText="M&#227; Game"></asp:BoundField>
            <asp:BoundField DataField="tengame" HeaderText="T&#234;n game"></asp:BoundField>
            <asp:BoundField DataField="gia" HeaderText="Gi&#225;(USD)"></asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href='<%#"Cart.aspx?xoa="+Eval("magame") %>'>Xóa</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Tổng tiền: "></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="Thanh toán" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Xóa tất cả" OnClick="Button2_Click" />
</asp:Content>

