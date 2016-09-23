<%@ Page Language="C#" MasterPageFile="../EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="IsssueEquipment.aspx.cs" Inherits="LURecCenterWeb.UI.forms.IsssueEquipment" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<asp:GridView ID="GridViewEquipment" runat="server" AutoGenerateColumns="false" DataKeyNames="IssueEqipmentId"
        OnRowDataBound="OnRowDataBound"
        OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added.">
        <Columns>
            <asp:TemplateField HeaderText="EquipmentName" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblEquipmentName" runat="server" Text='<%# Eval("EquipmentName") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EquipmentBARCode" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblEquipmentBARCode" runat="server" Text='<%# Eval("EquipmentBARCode") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IssueOn" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblEquipmentBrand" runat="server" Text='<%# Eval("IssueOn") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Issued To" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblEquipmentPrice" runat="server" Text='<%# Eval("PersonFullName") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mail ID" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblEquipmentPrice" runat="server" Text='<%# Eval("mailID") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowDeleteButton="true" DeleteText="Check-In" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>

    <table style="width: 500px; padding-top: 20px" cellspacing="5" cellpadding="5" border="1">
        <tr>
            <td style="width: 50%">Select Patron 
            </td>
            <td style="width: 50%">
                <asp:DropDownList ID="Dduserlist" runat="server">
                </asp:DropDownList>
            </td>

            <td>Select Equipment:
            </td>
            <td>
                <asp:DropDownList ID="ddEquipmentlist" runat="server">
                </asp:DropDownList>
            </td>

            <td>Enter comment :
            </td>
            <td>
                <asp:TextBox ID="txtcomment" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>

            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_click" Text="Isssue Equipment" />
            </td>
        </tr>
    </table>
    <%--   <asp:LinkButton runat="server" ID="adduser" OnClick="Link_Click" Text="Add user"> </asp:LinkButton>--%></asp:Content>
