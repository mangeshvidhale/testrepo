<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:Panel ID="Panel1" runat="server" style="margin-left: 28px" 
    Width="233px">
   <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login<br />
       <br />
        </div>
   <div style="width: 231px">UserName&nbsp;&nbsp;
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
       <br />
       Password&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       <br />
       <table style="width: 100%">
           <tr>
               <td style="width: 62px">
                   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">New 
                   User</asp:HyperLink>
               </td>
               <td style="width: 106px">
                   <asp:HyperLink ID="HyperLink2" runat="server">Forget Password</asp:HyperLink>
               </td>
               <td>
                   <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
               </td>
           </tr>
       </table>
       
       
       <table style="width: 100%">
           <tr>
               <td style="width: 300px; font-weight: 700;">
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <br />
                   &nbsp;<br />
                   &nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
                   &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
              
               
           </tr>
       </table>
        </div>
   
   
   
    </asp:Panel>
</asp:Content>

