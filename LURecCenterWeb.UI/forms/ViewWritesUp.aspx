<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../EmployeeMaster.Master" CodeBehind="ViewWritesUp.aspx.cs" Inherits="LURecCenterWeb.UI.forms.ViewWritesUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewwritesp" runat="server" AutoGenerateColumns="false" DataKeyNames="WritesUpid" EmptyDataText="No records has been added.">
        <Columns>
            <asp:TemplateField HeaderText="Write Up No" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblWritesUpid" runat="server" Text='<%# Eval("WritesUpid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Write Up Text" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblWritesUpText" runat="server" Text='<%# Eval("WritesUpText") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

</asp:Content>

