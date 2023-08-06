<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="Online_Exam.ViewStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link rel="stylesheet" href="stylesheet1.css">
</head>
<body style="background-image:url(online.png); background-repeat:no-repeat; background-size:cover; height: 371px;">
    <form id="form1" runat="server">
         <div class="topnav" style="-ms-align-content:center">
             <a href="#home">Students List</a>&nbsp;
        </div>
         <p>
&nbsp;&nbsp;&nbsp;
         </p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <p style="margin-left: 360px">
             &nbsp;</p>
         <p style="margin-left: 360px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                 <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                 <EditRowStyle BackColor="#999999" />
                 <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#E9E7E2" />
                 <SortedAscendingHeaderStyle BackColor="#506C8C" />
                 <SortedDescendingCellStyle BackColor="#FFFDF8" />
                 <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
             </asp:GridView>
         </p>
    </form>
</body>
</html>
