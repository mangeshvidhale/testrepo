<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label3" runat="server" Text="Welcome "></asp:Label>
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Enter where you want delivery"></asp:Label>
   <br />
    <asp:Label ID="Label4" runat="server" Text="Delivery Address"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Delivery City"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
     <br />
    <asp:Label ID="Label6" runat="server" Text="Delivery State  "></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Delivery Date"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" 
        ontextchanged="TextBox4_TextChanged"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Ok" onclick="Button1_Click" />

    <asp:Button ID="Button2" runat="server" Text="Proceed" 
        onclick="Button2_Click" />
    <br />
<br />
    <asp:Calendar ID="Calendar1" runat="server" Visible="False"></asp:Calendar>
</asp:Content>

