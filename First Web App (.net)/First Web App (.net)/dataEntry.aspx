<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataEntry.aspx.cs" Inherits="First_Web_App__.net_.dataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ID(to edit old data):
    
        <asp:TextBox ID="tbID" runat="server"></asp:TextBox>
    
    </div>
    <div>
    
        Name:
    
        <asp:TextBox ID="tbName" runat="server" OnTextChanged="tbName_TextChanged"></asp:TextBox>
    
    </div>
        <p>
            father Name:
            <asp:TextBox ID="tbFatherName" runat="server"></asp:TextBox>
        </p>
        <p>
            gender:
            <asp:RadioButton ID="rbMale" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbFemale" runat="server" Text="Female" />
        </p>
        <p>
            date of birth:
            <asp:TextBox ID="TBdateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            marital status: <asp:RadioButton ID="rbSingle" runat="server" Text="single" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbMarried" runat="server" Text="Married" />
        </p>
        <p>
            Religin:
            <asp:RadioButton ID="rbIslam" runat="server" Text="Islam" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbother" runat="server" Text="other" />
        </p>
        <p>
            Qualification:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CBMatric" runat="server" Text="Matric" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CBfsc" runat="server" Text="FSc." />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CBBS_BSc" runat="server" Text="BS/BSc" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CBother" runat="server" Text="Other" />
        </p>
        Address:<asp:TextBox ID="TBAddress" runat="server" Width="565px"></asp:TextBox>
&nbsp;<p>
            Phone Number: <asp:TextBox ID="TBphoneNo" runat="server" Width="194px"></asp:TextBox>
        </p>
        Email Id:
        <asp:TextBox ID="TBemail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOut" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnReset" runat="server" Height="61px" OnClick="btnReset_Click" Text="Reset" Width="130px" />
            <asp:Button ID="btnSubmit" runat="server" Height="60px" OnClick="btnSubmit_Click" Text="Submit" Width="130px" />
        </p>
        <asp:GridView ID="GridView1" runat="server" Height="374px" Width="660px">
        </asp:GridView>
    </form>
</body>
</html>
