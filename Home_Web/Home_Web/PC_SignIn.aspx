<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PC_SignIn.aspx.cs" Inherits="Home_Web.PC_SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    <title>Sign In</title>
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
                      <h1 class="display-2" style="color: #FFFFFF">Sign In Home IOT</h1>
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
                    <div class="col-lg-auto" style="height:50px">
                        <asp:Panel ID="Panel1" runat="server" >
                            <asp:Label ID="Label1" runat="server" Text="User:  " Font-Size="Large" ForeColor="White"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:Label ID="Label3" runat="server" Text="....."></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text="Password:  " Font-Size="Large" ForeColor="White"></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </asp:Panel>
                    </div>
                    <div class="col">
                     
                    </div>
                </div>
            </div>
        <%--Button End --%>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script> 
     
</body>
</html>
