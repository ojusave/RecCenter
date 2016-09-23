<%@ Page Title="Add equipment" Language="C#" MasterPageFile="../usermaster.Master" AutoEventWireup="true" CodeBehind="AddEquipment.aspx.cs" Inherits="LURecCenterWeb.UI.forms.AddEquipment" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 500px; padding-top: 20px" border="1">
        <tr>
            <td style="width: 50%">Equipment Name
            </td>
            <td style="width: 50%">
                <asp:TextBox ID="txtEquipmentName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Equipment BARCode 
            </td>
            <td>
                <asp:TextBox ID="txtEquipmentBARCode" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Equipment Brand
            </td>
            <td>
                <asp:TextBox ID="txtEquipmentBrand" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Equipment Type
            </td>
            <td>
                <asp:TextBox ID="txtPhone" TextMode="Phone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Equipment Add Date
            </td>
            <td>
                <asp:TextBox ID="txtEquipmentAddDate" TextMode="Date" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Equipment Price
            </td>
            <td>
                <asp:TextBox ID="txtEquipmentPrice" runat="server"></asp:TextBox>
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
