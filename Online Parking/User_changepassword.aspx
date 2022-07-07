<%@ Page Title="" Language="C#" MasterPageFile="~/m_User.Master" AutoEventWireup="true" CodeBehind="User_changepassword.aspx.cs" Inherits="Online_Parking.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 123px;
        }
        .style2
        {
            height: 21px;
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
                <asp:TextBox ID="txtCurrentpswd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Field cannot be empty" ControlToValidate="txtCurrentpswd" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         <%--   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNewpswd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Field cannot be empty" ControlToValidate="txtNewpswd" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtConfirmpswd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ErrorMessage="Password Mismatch" ControlToCompare="txtNewpswd" 
                    ControlToValidate="txtConfirmpswd" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style2">
                <asp:Button ID="bttnChange" runat="server" onclick="bttnChange_Click" 
                    Text="Change" />
            </td>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Incorrect Password" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
