<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobile_SignIn.aspx.cs" Inherits="Home_Web.Mobile_SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    <title>Sign In</title>
</head>
<body style="background-color: #003377;">
    <form id="form1" runat="server" defaultbutton="Button_LogIn">
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
        <%--Title End --%><%--Space Start --%>
            <%--<div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:20px">
                      <h3  style="color: #FFFFFF">   </h3>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>--%>
        <%--Space End --%><%--Textbox Start --%>
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
                        <asp:Button ID="Button_Back" runat="server" Text="Back" class="btn btn-secondary" Width="100px" TabIndex="1" OnClick="Button_Back_Click" />
                    </div>
                    <div class="col"> 
                        <asp:Button ID="Button_LogIn" runat="server" Text="Log In" class="btn btn-primary" Width="100px" OnClick="Button_LogIn_Click"/>
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                         
                    </div>
                </div>
            </div>  
        <%--Menu End --%><%--Space Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:50px">
                      <h3  style="color: #FFFFFF">   </h3>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Space End --%><%--Menu Start --%>
        <div class="container-fluid" style="text-align:center;">
                <div class="row align-items-center">
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                        <asp:Panel ID="Panel_A" runat="server">
                            <asp:Button ID="Button_A" runat="server" Text="Switch A" Width="150" type="button" class="btn btn-dark btn-lg" Height="50" Font-Size="X-Large" OnClick="Button_A_Click"/>
                        </asp:Panel>
                        
                    </div>
                    <div class="col"> 
                        <asp:Panel ID="Panel_B" runat="server">
                        <asp:Button ID="Button_B" runat="server" Text="Switch B" Width="150" type="button" class="btn btn-dark btn-lg" Height="50" Font-Size="X-Large" OnClick="Button_B_Click"/>
                            </asp:Panel>
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                         
                    </div>
                </div>
            </div>  
        <%--Menu End --%><%--Space Start --%>
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
        <%--Space End --%><%--Menu Start --%>
        <div class="container-fluid" style="text-align:center;">
                <div class="row align-items-center">
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                        <asp:Panel ID="Panel_C" runat="server">
                        <asp:Button ID="Button_C" runat="server" Text="Switch C" Width="150" type="button" class="btn btn-dark btn-lg" Height="50" Font-Size="X-Large" OnClick="Button_C_Click"/>
                            </asp:Panel>
                    </div>
                    <div class="col"> 
                       <asp:Panel ID="Panel_D" runat="server">
                        <asp:Button ID="Button_D" runat="server" Text="Switch D" Width="150" type="button" class="btn btn-dark btn-lg" Height="50" Font-Size="X-Large" OnClick="Button_D_Click"/>
                           </asp:Panel>
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                         
                    </div>
                </div>
            </div>  
        <%--Menu End --%><%--Space Start --%>
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
        <%--Space End --%><%--Menu Start --%>
        <div class="container-fluid" style="text-align:center;">
                <div class="row align-items-center">
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                        <asp:Panel ID="Panel_ON" runat="server">
                        <asp:Button ID="Button_ON" runat="server" Text="All ON" Width="150" type="button" class="btn btn-success btn-lg" Height="50" Font-Size="X-Large" OnClick="Button_ON_Click"/>
                        </asp:Panel>
                    </div>
                    <div class="col"> 
                        <asp:Panel ID="Panel_OFF" runat="server">
                        <asp:Button ID="Button_OFF" runat="server" Text="All OFF" Width="150" type="button" class="btn btn-danger btn-lg" Height="50" Font-Size="X-Large" OnClick="Button_OFF_Click"/>
                        </asp:Panel>
                    </div>
                    <div class="col"> 
                            
                    </div>
                    <div class="col"> 
                         
                    </div>
                </div>
            </div>  
        <%--Menu End --%><%--Space Start --%>
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
        <%--Space End --%><%--Content Start --%>
        <div class="container-fluid" >
                <div class="row align-items-center">
                    <div class="col"> 
                            
                    </div>
                    <div class="col">   
                        <asp:Panel ID="Panel_Content" runat="server"></asp:Panel>
                    </div>
                    <div class="col"> 
                        
                    </div>
                </div>
            </div>  
        
        
        <%--Content End --%>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script> 
     
</body>
</html>
