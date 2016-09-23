<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../EmployeeMaster.Master" CodeBehind="PickShift.aspx.cs" Inherits="LURecCenterWeb.UI.forms.PickShift" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <p> <b>Your picked shift : </b> </p>
    <asp:GridView ID="GridViewPickedShift" runat="server" AutoGenerateColumns="false" DataKeyNames="ShiftId"
        OnRowDataBound="OnRowDataBoundpk"  OnRowDeleting="OnRowDeletingpk" EmptyDataText="No records has been added.">
        <Columns>
            <asp:TemplateField HeaderText="ShiftName" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblpkShiftName" runat="server" Text='<%# Eval("ShiftName") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift Comment" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblpkShiftComment" runat="server" Text='<%# Eval("ShiftComment") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift Date" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblpkShiftDate" runat="server" Text='<%# Eval("ShiftDate") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift From" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblpkShiftFrom" runat="server" Text='<%# Eval("ShiftFrom") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift to" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblpkshiftto" runat="server" Text='<%# Eval("shiftto") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" DeleteText="Drop the Shift" ShowDeleteButton="true" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
   <p> <b> Avilable Shifts:  </b> </p>
    <asp:GridView ID="GridViewShift" runat="server" AutoGenerateColumns="false" DataKeyNames="ShiftId"
        OnRowDataBound="OnRowDataBound"  OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added.">
        <Columns>
            <asp:TemplateField HeaderText="ShiftName" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblShiftName" runat="server" Text='<%# Eval("ShiftName") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift Comment" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblShiftComment" runat="server" Text='<%# Eval("ShiftComment") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift Date" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblShiftDate" runat="server" Text='<%# Eval("ShiftDate") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift From" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblShiftFrom" runat="server" Text='<%# Eval("ShiftFrom") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Shift to" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblshiftto" runat="server" Text='<%# Eval("shiftto") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" DeleteText="Pick this shift" ShowDeleteButton="true" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>

</asp:Content>
