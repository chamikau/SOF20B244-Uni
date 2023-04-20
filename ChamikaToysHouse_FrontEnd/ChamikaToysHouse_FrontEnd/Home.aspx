<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChamikaToysHouse_FrontEnd.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="assets/ToyShopStyle.css" />
    <title></title>
</head>
<body style="background:#cabfe2">
    <form id="form1" runat="server">
        <div>
            <header>
                <div class="">
                  <img src = "images/header-banner.jpg" class="card-img-top"  style="height:170px" alt=""">
                </div>
            </header>
            <div>
             <asp:Literal ID="ToyControl" runat="server"></asp:Literal>
            </div>
            <footer>
                <div style="background: #de66e8cc">
                    <div class="row">
                        <div class="col-lg-8 col-md-8 col-sm-8 p-3 ms-3 mt-2">
                            <h4 class="footer-text">SOF/20/B2/44</h4>
                            <h4 class="footer-text">H.A.C.Umayanga</h4>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-3 p-3 d-flex text-center" style="align-items: center">
                            <h4 class="footer-text">Contact - 078 251 2152</h4>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </form>
</body>
</html>
