<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SignupControl.ascx.cs" Inherits="SignupControl" %>

    <h1>Sign up your account</h1>
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Re-enter Password"  ></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>