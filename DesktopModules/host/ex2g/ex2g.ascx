<%@ Control Language="VB" AutoEventWireup="false" Inherits="host.ex2g.ex2g" CodeFile="ex2g.ascx.vb" %>

<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>

<div class="dnnForm dnnEdit dnnClear" id="dnnEdit">
    <div>
        <asp:Label ID="Label1" style="width:100px;" runat="server" Text="FirstName: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" style="width:100px;" runat="server" Text="LastName: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>

    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

    <div>
        <asp:Button ID="Button1" runat="server" Text="Enter" />
        <asp:Button ID="Button2" runat="server" Text="Clear" />
    </div>
</div>



