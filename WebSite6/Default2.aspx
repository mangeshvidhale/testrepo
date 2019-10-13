<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Hello
        <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;Your cart is having the following items
        <asp:Label ID="Label2" runat="server"></asp:Label>
&nbsp;</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating" 
        onrowdeleting="GridView1_RowDeleting">
    <Columns>
    <asp:BoundField HeaderText="itemcode" DataField="itemcode" ReadOnly="true" />
    <asp:BoundField HeaderText="item_description" DataField="item_description" ReadOnly="true" />
    <asp:BoundField HeaderText="price" DataField="price" ReadOnly="true" />
    <asp:BoundField HeaderText="quantity" DataField="quantity" />
    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
    </Columns>
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="Proceed" 
        onclick="Button1_Click" />
</asp:Content>

