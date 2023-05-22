<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="CRECH.UI.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />  
    <script src="../Scripts/jquery-3.6.4.min.js"></script>  
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card" style="margin: 30px">
                    <div class="card-body">
                        <div class="row">
                            <div class="col text-center">
                                <img width="150px" src="../Images/adminuser.png" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col text-center">
                                <h3>Admin Login</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Username" ID="AdminUsernameTextBox" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                         <br />
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Password" ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                         <br />
                        <div class="row">
                            <div class="col">
                                <div class="col text-center">
                                    <asp:Button class="btn btn-block btn-success btn-lg" ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
                                    <br />
                                    <br />
                                    <a class="btn btn-secondary btn-lg btn-block" href="UserLogin.aspx">User Login</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
            </div>
        </div>
    </div>
    </form>
</body>
</html>
