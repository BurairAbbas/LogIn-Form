<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 121px;
        }
        .auto-style2 {
            width: 89px;
            height: 30px;
        }
        .auto-style3 {
            width: 90px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: burlywood; height: 384px; width: 709px;">
            <div style="float: left">
                <table style="height: 383px; width: 339px">
                    <tr>
                        <td>ID No:
                        </td>
                        <td>
                            <asp:TextBox ID="IDtb" runat="server" placeholder =""></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="Findbt" runat="server" Text="Find" OnClick="Findbt_Click" />
                        </td>
                    </tr>
                    <tr>
                        <!----Lable---->
                        <td colspan="2" style="padding:0px;margin:0px">
                            <asp:Label ID="lblMsg" runat="server" Text=""  ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Emp Name:
                        </td>
                        <td>
                            <asp:TextBox ID="Emptb" runat="server" placeholder="Enter Your Name!!"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Father Name:
                        </td>
                        <td>
                            <asp:TextBox ID="FNametb" runat="server" placeholder="Enter Your Father Name!!" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Contact No:
                        </td>
                        <td>
                            <asp:TextBox ID="Contact_tb" runat="server" placeholder ="Enter Contact Number!!"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>CNIC No:
                        </td>
                        <td>
                            <asp:TextBox ID="CNICtb" runat="server" placeholder ="Enter CNIC Number!!"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Address:
                        </td>
                        <td>
                            <asp:TextBox ID="Addresstb" runat="server" TextMode="MultiLine" Height="50px" Width="155px" placeholder ="Enter your Address!!"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Gender:
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                        </td>
                    </tr>
                    <tr>
                        <td>Basic Salary:
                        </td>
                        <td>
                            <asp:TextBox ID="BSalarytb" runat="server"></asp:TextBox>
                        </td>
                    </tr>


                </table>
            </div>

            <!---second div---->
            <div style="float: left">
                <table style="height: 89px; width: 339px">
                    <tr>
                        <td>                            
                            <asp:Image ID="Image1" runat="server" BorderStyle="Dashed" Width="150px" Height="110px" style="text-align:center" AlternateText="Upload for Image Here..." />
                        </td>
                        <td class="auto-style1">
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="181px" />
                            <asp:Button ID="Uploadbt" runat="server" Text="Upload" OnClick="Uploadbt_Click" />
                            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                        </td>

                    </tr>
                    <tr>
                        <td>Designation:
                        </td>
                        <td class="auto-style1">
                            <!-- You can add listItem here and as well as click on dropdown their is small arrow on right click on it Add Existed item and Add your item from desige -->
                            <asp:DropDownList ID="DesigList" runat="server">
                                
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem Value="2">Front-End</asp:ListItem>                                
                                <asp:ListItem Value="3">Back-End</asp:ListItem>
                                <asp:ListItem Value="4">Manager</asp:ListItem>
                                <asp:ListItem Value="5">Team-Lead</asp:ListItem>
                                
                                <asp:ListItem Value="1">Full-Stack</asp:ListItem>
                                
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Department:
                        </td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="DepartList" runat="server">
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem Value="2">Client Service</asp:ListItem>
                                <asp:ListItem Value="3">Software House</asp:ListItem>
                                <asp:ListItem Value="4">Gound Depart</asp:ListItem>
                                <asp:ListItem Value="5">MIS</asp:ListItem>
                                <asp:ListItem Value="1">HR</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>DOB:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="DOBtb" runat="server" placeholder="dd/mm/yyyy"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>DOJ:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="DOJtb" runat="server" placeholder="dd/mm/yyyy"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>DOL:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="DOLtb" runat="server" placeholder="Enter Days!!"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Type of Leave:
                        </td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Value="1">Sick leave</asp:ListItem>
                                <asp:ListItem Value="2">Vacation Leave</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    
                </table>
            </div>
            <div style ="float:right; width: 370px; height: 78px; background-color:burlywood">
                <table>
                    <tr>
                        <td style="padding-right: 30px" class="auto-style2">
                            <asp:Button ID="Inserttb" runat="server" Text="Insert" Width="67px" Height="39px" Font-Bold="true" OnClick="Inserttb_Click" />
                            </td>
                        <td style="padding:30px" class="auto-style3">
                            <asp:Button ID="Updatetb" runat="server" Text="Update" Width="67px" Height="39px" Font-Bold="true" OnClick="Updatetb_Click"/>
                        </td>
                        <td class="auto-style4"  style ="padding:30px" >
                            <asp:Button ID="Deletebt" runat="server" Text="Delete" Width="67px" Height="39px" Font-Bold="true" OnClick="Deletebt_Click"/>
                        </td>                      
                    </tr>                   
                </table>
            </div>
        </div>
        

        <asp:Label ID="ImageName" runat="server" Visible="False"></asp:Label>
        

    </form>
</body>
</html>
