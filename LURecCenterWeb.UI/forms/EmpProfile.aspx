<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="../EmployeeMaster.Master"  CodeBehind="EmpProfile.aspx.cs" Inherits="LURecCenterWeb.UI.forms.Profile" %>

<asp:content id="BodyContent" contentplaceholderid="MainContent" runat="server">
   <asp:HiddenField ID="hdnuserid1" runat="server" />
   <table  style="width:500px; padding-top:20px" border="1">          
         <tr>
           <td>
               Email
           </td>
            <td>
               <asp:TextBox ID="txtemail1" TextMode="Email" runat="server" ></asp:TextBox>
           </td>
       </tr>
         <tr>
           <td>
               Phone
           </td>
            <td>
                 <asp:TextBox ID="txtPhone1"  TextMode="Phone" runat="server" ></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td>
               Date of Birth
           </td>
            <td>
                 <asp:TextBox ID="txtDOB1" TextMode="Date" runat="server" ></asp:TextBox>
           </td>
       </tr>
         <tr>
           <td>
               First Name
           </td>
            <td>
                  <asp:TextBox ID="txtfrstname1" runat="server" ></asp:TextBox>
           </td>
       </tr>
        <tr>
           <td>
             Last Name
           </td>
            <td>
           <asp:TextBox ID="txtlastname1" runat="server" ></asp:TextBox>
           </td>
       </tr>
        <tr>
           <td>
              Address
           </td>
            <td>
            <asp:TextBox ID="txtAddress1" TextMode="MultiLine" runat="server" ></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td>
              PIN Code
           </td>
            <td>
            <asp:TextBox ID="txtpin1"  runat="server" ></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
             
           </td>
            <td>
                <asp:Button ID="btnSubmit1" runat="server" OnClick="btnSubmit1_click"  Text="Edit" />
           </td>
       </tr>
   </table>
</asp:content>
