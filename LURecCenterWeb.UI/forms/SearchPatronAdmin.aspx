<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../usermaster.Master" CodeBehind="SearchPatron.aspx.cs" Inherits="LURecCenterWeb.UI.forms.SearchPatron" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="hdnuserid" runat="server" />
       <br />
    <table width="500px">
        <tr>
            <td>Select ID Card:</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button Text="Upload" runat="server" OnClick="Upload" /></td>
        </tr>
    </table>

    <hr />
    <table width="500px">
        <tr>
            <td>Search Student </td>
            <td>
                <asp:TextBox runat="server" ID="TxtIdNumber"></asp:TextBox>
            </td>
            <td>
                   <asp:Button Text="Check-in" runat="server" OnClick="Search_Student" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <table  style="width:500px; padding-top:20px" border="1">          
         <tr>
           <td>
               Email
           </td>
            <td>
               <asp:TextBox ID="txtemail" TextMode="Email" runat="server" ></asp:TextBox>
           </td>
       </tr>
         <tr>
           <td>
               Phone
           </td>
            <td>
                 <asp:TextBox ID="txtPhone"  TextMode="Phone" runat="server" ></asp:TextBox>
           </td>
       </tr>
       
         <tr>
           <td>
               First Name
           </td>
            <td>
                  <asp:TextBox ID="txtfrstname" runat="server" ></asp:TextBox>
           </td>
       </tr>
        <tr>
           <td>
             Last Name
           </td>
            <td>
           <asp:TextBox ID="txtlastname" runat="server" ></asp:TextBox>
           </td>
       </tr>
        <tr>
           <td>
              Address
           </td>
            <td>
            <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server" ></asp:TextBox>
           </td>
       </tr>
       
        <tr>
           <td>
               <asp:Label ID="Label1" runat="server"></asp:Label>
           </td>
            <td>
                &nbsp;</td>
       </tr>
       
   </table>
</asp:Content>
