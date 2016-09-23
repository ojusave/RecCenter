<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../usermaster.Master" CodeBehind="CreateShift.aspx.cs" Inherits="LURecCenterWeb.UI.forms.CreateShift" %>

<%@ Register Assembly="TimePicker" Namespace="MKB.TimePicker" TagPrefix="cc1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="align-items: center; float: right">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000">
                </asp:Timer>
                <asp:Label ID="lblcurrentDay" Font-Size="Medium" Font-Bold="true" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblcurrenttime" Font-Size="Medium" Font-Bold="true" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>


    <div>

        <table style="width: 600px">
            <tr>
                <td>Shift Name
                </td>
                <td>
                    <asp:TextBox ID="txtShiftName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Select Date to Create Shift:
                </td>
                <td>
                    <asp:Calendar runat="server" ID="Shiftfromclanderdate"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Select time from:
                </td>
                <td>
                    <asp:DropDownList ID="ddtimeFrom" runat="server" AutoPostBack="true">
                        <asp:ListItem Value="1">01</asp:ListItem>
                        <asp:ListItem Value="2">02</asp:ListItem>
                        <asp:ListItem Value="3">03</asp:ListItem>
                        <asp:ListItem Value="4">04</asp:ListItem>
                        <asp:ListItem Value="5">05</asp:ListItem>
                        <asp:ListItem Value="6">06</asp:ListItem>
                        <asp:ListItem Value="7">07</asp:ListItem>
                        <asp:ListItem Value="8">08</asp:ListItem>
                        <asp:ListItem Value="9">09</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                        <asp:ListItem Value="11">11</asp:ListItem>
                        <asp:ListItem Value="12">12</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddampm" runat="server">
                        <asp:ListItem Value="AM">AM</asp:ListItem>
                        <asp:ListItem Value="PM">PM</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    &nbsp;</td>
            </tr>

            <tr>
                <td>Enter Comments:
                </td>
                <td>
                    <asp:TextBox ID="txtComment" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_click" Text="Create Shift" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>


</asp:Content>

