<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Hello! <asp:Label ID="Label1" runat="server"></asp:Label>
   <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
      <br />
        <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
     <Columns>
            <asp:BoundField DataField="itemcode" HeaderText="itemcode" 
                SortExpression="itemcode" />
            <asp:BoundField DataField="item_description" HeaderText="item_description" 
                SortExpression="item_description" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
        </Columns>
    </asp:GridView>
    <br />
        <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Signout" />
</asp:Content>

