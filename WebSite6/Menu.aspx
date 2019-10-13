<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Default7" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
        <asp:TemplateField HeaderText="Select">
					<ItemTemplate>
						<asp:CheckBox ID="cb1" runat="server" Enabled="true" />
					</ItemTemplate>
				</asp:TemplateField>

            <asp:BoundField DataField="itemcode" HeaderText="itemcode" 
                SortExpression="itemcode" />
            <asp:BoundField DataField="item_description" HeaderText="item_description" 
                SortExpression="item_description" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="cb1" runat="server" Text="Add to Cart" 
    onclick="Purchase_Click" />
     

</asp:Content>

