<%@ Page Title="" Language="C#" MasterPageFile="~/m_Landowner.Master" AutoEventWireup="true" CodeBehind="LandOwner_Login.aspx.cs" Inherits="Online_Parking.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 132px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="LandOwner id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLandownerid" runat="server" 
                    ontextchanged="txtLandownerid_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Field cannot be empty" ControlToValidate="txtLandownerid" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="bttnLogin" runat="server" onclick="Button1_Click" 
                    Text="Login" />
            </td>
        </tr>
    </table>
</asp:Content>
