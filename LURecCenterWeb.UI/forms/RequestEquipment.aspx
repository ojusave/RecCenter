<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../visitermaster.Master" CodeBehind="RequestEquipment.aspx.cs" Inherits="LURecCenterWeb.UI.forms.Writeups" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="hdnuserid1" runat="server" />
    <table style="width: 500px; padding-top: 20px" border="1">
        <tr>
            <td>Enter Email 
            </td>
            <td>
                <asp:TextBox ID="txtemail1" TextMode="Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Request Item
            </td>
            <td>
              <asp:TextBox ID="txtwritesup1" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit1" runat="server" Text ="Request"/>
            </td>
        </tr>
    </table>
</asp:Content>
