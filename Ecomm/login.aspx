<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ecomm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8"/>
 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
 <meta name="description" content=""/>
 <meta name="author" content=""/>
 <link rel="icon" href="favicon.ico"/>
 <title>Tiny Dashboard - A Bootstrap Dashboard Template</title>
 <!-- Simple bar CSS -->
 <link rel="stylesheet" href="css/simplebar.css"/>
 <!-- Fonts CSS -->
 <link href="https://fonts.googleapis.com/css2?family=Overpass:ital,wght@0,100;0,200;0,300;0,400;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet"/>
 <!-- Icons CSS -->
 <link rel="stylesheet" href="css/feather.css"/>
 <!-- Date Range Picker CSS -->
 <link rel="stylesheet" href="css/daterangepicker.css"/>
 <!-- App CSS -->
 <link rel="stylesheet" href="css/app-light.css" id="lightTheme"/>
</head>
<body class="light rtl" >
     <div class="wrapper vh-100">
   <div class="row align-items-center h-100">
     <form id="form1" runat="server" class="col-lg-3 col-md-4 col-10 mx-auto text-center">
       <a class="navbar-brand mx-auto mt-2 flex-fill text-center" href="./index.html">
         <svg version="1.1" id="logo" class="navbar-brand-img brand-md" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 120 120" xml:space="preserve">
           <g>
             <polygon class="st0" points="78,105 15,105 24,87 87,87 	" />
             <polygon class="st0" points="96,69 33,69 42,51 105,51 	" />
             <polygon class="st0" points="78,33 15,33 24,15 87,15 	" />
           </g>
         </svg>
       </a>
       <h1 class="h6 mb-3">התחברות</h1>
       <div class="form-group">
         <label for="TxtEmail" class="sr-only">Email address</label>
         
           <asp:TextBox ID="TxtEmail" runat="server" placeholder="נא להזין כתובת אימייל" Class="form-control-lg" />
       </div>
       <div class="form-group">
         <label for="TxtPass" class="sr-only">Password</label>
         
           <asp:TextBox ID="TextPass" runat="server" TextMode="Password" placeholder="נא להזין סיסמא" Class="form-control-lg" />

       </div>
       <div class="checkbox mb-3">
         <label>
           <input type="checkbox" value="remember-me"/> Stay logged in </label>
       </div>
         <asp:Button runat="server" ID="BtnLogin" Text="התחברות" Class="btn btn-lg btn-primary btn-block" OnClick="BtnLogin_Click" />
       <p class="mt-5 mb-3 text-muted">© 2025</p>
     </form>
   </div>
 </div>
 <script src="js/jquery.min.js"></script>
 <script src="js/popper.min.js"></script>
 <script src="js/moment.min.js"></script>
 <script src="js/bootstrap.min.js"></script>
 <script src="js/simplebar.min.js"></script>
 <script src='js/daterangepicker.js'></script>
 <script src='js/jquery.stickOnScroll.js'></script>
 <script src="js/tinycolor-min.js"></script>
 <script src="js/config.js"></script>
 <script src="js/apps.js"></script>
</body>
</html>
