<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../usermaster.Master" CodeBehind="ViewEquipment.aspx.cs" Inherits="LURecCenterWeb.UI.forms.ViewEquipment" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewEquipment" runat="server" AutoGenerateColumns="false" DataKeyNames="EquipmentID"
OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added.">
<Columns>
    <asp:TemplateField HeaderText="EquipmentName" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblEquipmentName" runat="server" Text='<%# Eval("EquipmentName") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtEquipmentName" runat="server" Text='<%# Eval("EquipmentName") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="EquipmentBARCode" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblEquipmentBARCode" runat="server" Text='<%# Eval("EquipmentBARCode") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtEquipmentBARCode" runat="server" Text='<%# Eval("EquipmentBARCode") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="EquipmentBrand" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblEquipmentBrand" runat="server" Text='<%# Eval("EquipmentBrand") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtEquipmentBrand" runat="server" Text='<%# Eval("EquipmentBrand") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="EquipmentPrice" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblEquipmentPrice" runat="server" Text='<%# Eval("EquipmentPrice") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtEquipmentPrice" runat="server" Text='<%# Eval("EquipmentPrice") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    
    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" ItemStyle-Width="150"/>
</Columns>
</asp:GridView>
<table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
<tr>
    <td style="width: 150px">
      
        <asp:TextBox ID="txtEquipmentName" runat="server" Width="140" />
    </td>
    <td style="width: 150px">
      
        <asp:TextBox ID="txtEquipmentBARCode" runat="server" Width="140" />
    </td>
    <td style="width: 150px">
       
        <asp:TextBox ID="txtEquipmentBrand" runat="server" Width="140" />
    </td>
    <td style="width: 150px">
       
        <asp:TextBox ID="txtEquipmentPrice" runat="server" Width="140" />
    </td>
    <td style="width: 100px">
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Insert" />
    </td>
</tr>
</table>
</asp:Content>
