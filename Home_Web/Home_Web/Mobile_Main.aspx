<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobile_Main.aspx.cs" Inherits="Home_Web.Mobile_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    <title>Mobile Main</title>
</head>
<body style="background-color: #003377;">
    <form id="form1" runat="server" defaultbutton="Button_signin">
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
        <%--Space End --%><%--Button Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:100px">
                        <asp:Button ID="Button_register" runat="server" Text="Register" Width="300" type="button" class="btn btn-secondary btn-lg" Height="100" Font-Size="XX-Large" OnClick="Button_register_Click"/>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Button End --%><%--Button Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:100px">
                        <asp:Button ID="Button_signin" runat="server" Text="Sign In" Width="300" type="button" class="btn btn-primary btn-lg" Height="100" Font-Size="XX-Large" OnClick="Button_signin_Click"/>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Button End --%><%--Button Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:100px">
                        <asp:Button ID="Button_manager" runat="server" Text="Data Moniter" Width="300" type="button" class="btn btn-secondary btn-lg" Height="100" Font-Size="XX-Large" OnClick="Button_manager_Click"/>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Button End --%><%--Space Start --%>
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
        <%--Space End --%><%--Link Start --%>
            <div class="container-fluid">
                <div class="row align-items-center">
                    
                    <div class="col">
                      
                    </div>
                    <div class="col-lg-auto" style="height:100px">
                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Larger" OnClick="LinkButton1_Click">Go to PC page</asp:LinkButton>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Link End --%>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script> 
     
</body>
</html>
