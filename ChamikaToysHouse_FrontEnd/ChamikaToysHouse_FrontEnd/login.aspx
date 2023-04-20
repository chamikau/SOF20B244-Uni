<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ChamikaToysHouse_FrontEnd.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="assets/LoginStyle.css" />
    <title></title>
</head>
<body>
    <div class="container-fluid w-50 p-4">
        <div class="justify-content-center">
            <div class="row text-center">
                <div>
                    <img src = "images/logo.png" class="card-img-top" alt="" style="height:10rem;width:10rem;">
                    <form id="form1" class="mt-3" runat="server">
                        <div class="card">
                            <div class="card-body justify-content-center">
                                <h1 class="h3 mb-3 fw-normal">SIGN IN</h1>
                                <asp:Label Style="color: red; border: 1px" ID="errorShow" class="errorShow" runat="server"></asp:Label>
                                <div class="form-floating mt-3">
                                    <asp:TextBox runat="server" type="text" class="form-control" ID="username" placeholder="name@example.com" />
                                    <label for="floatingInput">User Name</label>
                                </div>
                                <asp:Label Style="color: red" ID="errorUser" class="errorUser" runat="server"></asp:Label>
                                <div class="form-floating mt-3">
                                    <asp:TextBox runat="server" type="password" class="form-control" ID="password" placeholder="Password" />
                                    <asp:Label Style="color: red" ID="Label1" class="errorShow" runat="server"></asp:Label>
                                    <label for="floatingPassword">Password</label>
                                </div>
                                <asp:Label Style="color: red" ID="errorPassword" class="errorPassword" runat="server"></asp:Label>
                                <asp:Button runat="server" class="w-100 btn btn-lg btn-primary mt-3" type="submit" Text="Sign in" OnClick="Unnamed1_Click" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
