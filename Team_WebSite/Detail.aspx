<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1> <asp:Label ID="Label3" runat="server" Text=""></asp:Label></h1>
    <br /><br />
    <asp:Image ID="Image1" runat="server"  Width="300" CssClass="CurrentProduct"/>
    <h3><asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="Thêm vào giỏ hàng" OnClick="Button1_Click" />
    <h2 class="AfterCurrentProduct"><br /><br />More of Popular Games</h2><br />
    <div style="overflow-x:auto;">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" CssClass="MoreGames">
            <ItemTemplate>
                <a href='<%#"Detail.aspx?tengame="+Eval("tengame")%>'><asp:Image runat="server" ImageUrl='<%#"~/Games/"+Eval("fname") %>' Width="200" /></a><br />
                <p style="text-align:center;"><asp:Label runat="server" Text='<%#Eval("tengame")%>' Width="100"></asp:Label></p>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <br />
    <br />
    <script>
        function baoLoi() {
            alert("Sản phẩm đã có trong giỏ hàng!");
        }
        function thongBao() {
            alert("Thêm vào giỏ hàng thành công!");
        }
    </script>
</asp:Content>

