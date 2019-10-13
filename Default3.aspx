<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="wants to buy the following items"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
    <asp:BoundField HeaderText="itemcode" DataField="itemcode" ReadOnly="true" />
    <asp:BoundField HeaderText="item_description" DataField="item_description" ReadOnly="true" />
    <asp:BoundField HeaderText="price" DataField="price" ReadOnly="true" />
    <asp:BoundField HeaderText="quantity" DataField="quantity" />
    </Columns>
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="where do you want delivery" 
        onclick="Button1_Click" />
</asp:Content>

