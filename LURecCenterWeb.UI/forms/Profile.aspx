<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="../Visitermaster.Master"  CodeBehind="Profile.aspx.cs" Inherits="LURecCenterWeb.UI.forms.Profile" %>

<asp:content id="BodyContent" contentplaceholderid="MainContent" runat="server">
   <asp:HiddenField ID="hdnuserid" runat="server" />
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
               Date of Birth
           </td>
            <td>
                 <asp:TextBox ID="txtDOB" TextMode="Date" runat="server" ></asp:TextBox>
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
              PIN Code
           </td>
            <td>
            <asp:TextBox ID="txtpin"  runat="server" ></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
             
           </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_click"  Text="Edit" />
           </td>
       </tr>
   </table>
</asp:content>
