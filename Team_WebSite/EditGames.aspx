<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="EditGames.aspx.cs" Inherits="EditGames" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Thêm game</h1>
    <table>
        <tr>
            <td>Mã game</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tên game</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Giá bán</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Ảnh đại diện</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Thêm" Width="66px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>


    <h1>Chỉnh sửa thông tin game</h1>
    <table>
        <tr>
            <td>Mã game</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tên game</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Không bỏ trống ô này!" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Giá bán</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Không bỏ trống ô này!" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Ảnh đại diện</td>
            <td>
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Cập nhật" OnClick="Button3_Click" />
            </td>
        </tr>
    </table>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <h1>Xóa game</h1>
    <table>
        <tr>
            <td>Mã game</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Xóa" Width="61px" OnClick="Button2_Click" />
            </td>
    </table>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
    <a href="EditGames.aspx?xem=yes">Xem chi tiết của tất cả Game mà cửa hàng có</a><br /><br />
    <div style="overflow-x:auto;">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" CssClass="MoreGames">
            <ItemTemplate>
                <a href='<%#"Detail.aspx?tengame="+Eval("tengame")%>'><asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/Games/"+Eval("fname") %>' Width="200"  Height="200"/></a><br />
                <p style="text-align:center;">
                    <asp:Label runat="server" Text='<%#Eval("tengame")%>' Width="200"></asp:Label><br />
                    <asp:Label runat="server" Text='<%#"Giá: $"+Eval("gia") %>'></asp:Label><br />
                    <asp:Label runat="server" Text='<%#"Mã Game: "+Eval("magame") %>'></asp:Label>
                </p>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    <br /><br />
</asp:Content>

