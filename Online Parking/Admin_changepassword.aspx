<%@ Page Title="" Language="C#" MasterPageFile="~/m_Admin.Master" AutoEventWireup="true" CodeBehind="Admin_changepassword.aspx.cs" Inherits="Online_Parking.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 167px;
            margin-bottom: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Current Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCurrentpw" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtCurrentpw" ErrorMessage="This field cannot be empty" 
                    ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNewpw" runat="server" ontextchanged="txtNewpw_TextChanged" 
                    TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtNewpw" ErrorMessage="This field cannot be empty" 
                    ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtConfirmpw" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtNewpw" ControlToValidate="txtConfirmpw" 
                    ErrorMessage="Password mismatch" ForeColor="#CC0000"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="bttnSubmit" runat="server" onclick="bttnSubmit_Click" 
                    style="margin-bottom: 7px" Text="Change" />
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" ForeColor="#CC0000" 
                    Text="Incorrect Password" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
