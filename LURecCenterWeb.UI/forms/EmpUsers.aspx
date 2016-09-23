<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../EmployeeMaster.Master" CodeBehind="EmpUsers.aspx.cs" Inherits="LURecCenterWeb.UI.forms.ViewUsers" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewUser" runat="server" AutoGenerateColumns="false" DataKeyNames="UserId"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added.">
        <Columns>
            <asp:TemplateField HeaderText="UserName" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lbluserName" runat="server" Text='<%# Eval("userName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtuserName" runat="server" Text='<%# Eval("userName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Firstname" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblfirstname" runat="server" Text='<%# Eval("firstname") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtfirstname" runat="server" Text='<%# Eval("firstname") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lastname" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lbllastname" runat="server" Text='<%# Eval("lastname") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtlastname" runat="server" Text='<%# Eval("lastname") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblemailid" runat="server" Text='<%# Eval("emailid") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtemailid" runat="server" Text='<%# Eval("emailid") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Phone" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblphone" runat="server" Text='<%# Eval("phone") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtphone" runat="server" Text='<%# Eval("phone") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lbladdress" runat="server" Text='<%# Eval("address") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtaddress" runat="server" Text='<%# Eval("address") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
    
</asp:Content>
