<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../EmployeeMaster.Master" CodeBehind="ViewLoginHistory.aspx.cs" Inherits="LURecCenterWeb.UI.forms.ViewLoginHistory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewEquipment" runat="server" AutoGenerateColumns="false" DataKeyNames="SessionId" EmptyDataText="No records has been added." OnSelectedIndexChanged="GridViewEquipment_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="User Name" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lbluserName" runat="server" Text='<%# Eval("userName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="fullname" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblfullname" runat="server" Text='<%# Eval("fullname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LoginDate" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblLoginDate" runat="server" Text='<%# Eval("LoginDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LoginTime" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblLoginTime" runat="server" Text='<%# Eval("LoginTime") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LoggedOutdate" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblLoggedOutdate" runat="server" Text='<%# Eval("LoggedOutdate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LoggedOuttime" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblLoggedOuttime" runat="server" Text='<%# Eval("LoggedOuttime") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>

