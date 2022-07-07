<%@ Page Title="" Language="C#" MasterPageFile="~/m_Admin.Master" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="Online_Parking.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 163px;
        }
        .style2
        {
            width: 248px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Admin id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAdminid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Field cannot be empty" ControlToValidate="txtAdminid" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="bttnLogin" runat="server" Text="Login" 
                    onclick="bttnLogin_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
