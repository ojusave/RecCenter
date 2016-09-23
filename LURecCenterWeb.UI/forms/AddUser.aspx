<%@ Page Title="Add user" Language="C#" MasterPageFile="../usermaster.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="LURecCenterWeb.UI.forms.AddUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 500px; padding-top: 20px" border="1">
        <tr>
            <td style="width: 50%">User Name
            </td>
            <td style="width: 50%">
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password 
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>User Type 
            </td>
            <td>
                <asp:DropDownList ID="ddUserType" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Email
            </td>
            <td>
                <asp:TextBox ID="txtemail" TextMode="Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>ID Number
            </td>
            <td>
                <asp:TextBox ID="txtIdNumber" TextMode="Phone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone
            </td>
            <td>
                <asp:TextBox ID="txtPhone" TextMode="Phone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Date of Birth
            </td>
            <td>
                <asp:TextBox ID="txtDOB" TextMode="Date" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>First Name
            </td>
            <td>
                <asp:TextBox ID="txtfrstname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name
            </td>
            <td>
                <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address
            </td>
            <td>
                <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>PIN Code
            </td>
            <td>
                <asp:TextBox ID="txtpin" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_click" Text="Save" />
            </td>
        </tr>
    </table>
</asp:Content>
