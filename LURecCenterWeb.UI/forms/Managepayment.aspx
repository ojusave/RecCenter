<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../usermaster.Master" CodeBehind="Managepayment.aspx.cs" Inherits="LURecCenterWeb.UI.forms.Managepayment" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="hdnuserid" runat="server" />
    <table style="width: 500px; padding-top: 20px" border="1">
        <tr>
            <td>Select employee: 
            </td>
            <td>
                <asp:TextBox ID="txtemail" TextMode="Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Salary Amount: 
            </td>
            <td>
                <asp:TextBox ID="txtPhone" TextMode="Phone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_click" Text="Pay Salary" />
            </td>
        </tr>
    </table>
</asp:Content>
