<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobile_Register.aspx.cs" Inherits="Home_Web.Mobile_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    <title>Register</title>
</head>
<body style="background-color: #003377;">
    <form id="form1" runat="server">
        <div>
            <%--Title Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    
                    <div class="col">
                      
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                      
                    </div>
                    <div class="col-lg-auto" style="height:100px">
                      <h1 class="display-4" style="color: #FFFFFF">Home IOT</h1>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Title End --%><%--Textbox Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:150px">
                        <asp:Panel ID="Panel1" runat="server" >
                            <asp:Label ID="Label1" runat="server" Text="User ID :  " Font-Size="Large" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label4" runat="server" Text="_" ForeColor="#003377"></asp:Label>
                            <asp:TextBox ID="TextBox_ID" runat="server" placeholder="  User ID" class="form-control"></asp:TextBox>
                            <asp:Label ID="Label2" runat="server" Text="Password :  " Font-Size="Large" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label5" runat="server" Text="_" ForeColor="#003377"></asp:Label>
                            <asp:TextBox ID="TextBox_PW" runat="server" type="password" placeholder="  Password" class="form-control"></asp:TextBox>
                        </asp:Panel>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Textbox End --%><%--Menu Start --%>
        <div class="container-fluid" style="text-align:center;">
                <div class="row align-items-center">
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                        <asp:Button ID="Button_Back" runat="server" Text="Back" class="btn btn-secondary" Width="100px" TabIndex="1" OnClick="Button_Back_Click"  />
                    </div>
                    <div class="col"> 
                        <asp:Button ID="Button_LogIn" runat="server" Text="Log In" class="btn btn-primary" Width="100px" OnClick="Button_LogIn_Click" />
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                         
                    </div>
                </div>
            </div>  
        <%--Menu End --%>
            <asp:Panel ID="Panel_Register" runat="server" Enabled="False">
                <%--Server NO Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:80px">
                        <asp:Label ID="Label6" runat="server" Text="Server Number: " Font-Size="Large" ForeColor="White"></asp:Label>
                        <asp:TextBox ID="TextBox_Server" runat="server" placeholder="Server NO." class="form-control" Width="250"></asp:TextBox>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Server NO End --%><%--Client NO Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:80px">
                        <asp:Label ID="Label7" runat="server" Text="Client Number: " Font-Size="Large" ForeColor="White"></asp:Label>
                        <asp:TextBox ID="TextBox_Client" runat="server" placeholder="Client NO." class="form-control" Width="250"></asp:TextBox>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Client NO End --%><%--Client Type Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:80px">
                        <asp:Label ID="Label8" runat="server" Text="Client Type: " Font-Size="Large" ForeColor="White"></asp:Label>
                        <asp:DropDownList ID="DropDownList_ClientType" runat="server" class="form-control" Width="250">
                            <asp:ListItem>Switch</asp:ListItem>
                            <asp:ListItem>Double Switch</asp:ListItem>
                            <asp:ListItem>Fan</asp:ListItem>
                            <asp:ListItem>Air conditioner</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Client Type End --%><%--Space Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:20px">
                      <h3  style="color: #FFFFFF">   </h3>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Space End --%><%--Submit Button Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:80px">
                        <asp:Button ID="Button_Submit" runat="server" Text="Submit Register" class="btn btn-success" Width="200px"  TabIndex="-1" OnClick="Button_Submit_Click"  />
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Submit Button End --%>
            </asp:Panel>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script> 
     
</body>
</html>
