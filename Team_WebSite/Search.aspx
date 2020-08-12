<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Kết quả tìm kiếm: <asp:Label ID="Label2" runat="server" Text=""></asp:Label></h1>
     <asp:DataList ID="DataList1" runat="server" CssClass="MoreGames">
            <ItemTemplate>
                <a href='<%#"Detail.aspx?tengame="+Eval("tengame")%>'><asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/Games/"+Eval("fname") %>' Width="200" /></a><br />
                <p style="text-align:center;"><asp:Label runat="server" Text='<%#Eval("tengame")%>' Width="200"></asp:Label></p>
            </ItemTemplate>
     </asp:DataList>
</asp:Content>

