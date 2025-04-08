<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Ecomm.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>

</head>
<body>
    <form id="form1" runat="server">
        <div   class ="container">
          <!--  <div class="row">
                <div class =" col-md-6">

                       <div><input type ="text" name =" user" id="user" class="form-control" /> </div>
                       <div>  <input type ="password" name =" Pass" id="Pass" class="form-control"/> </div>
                       <div> <button type="button" name="BtnLogin" id="BtnLogin2" class="btn btn-success">התחבר</button> </div>

                </div>
            </div> -->

            <div class="row">
             <div class =" col-md-6">

           <div> <asp:TextBox ID="TextEmail" runat="server" CssClass="form-control" TextMode="Email"/> </div> 
           <div>  <asp:TextBox ID="TextPass" runat="server" CssClass="form-control" TextMode="Password" /> </div>
           <div> <asp:Button ID="BtnLogin" runat="server" CssClass="btn btn-success" Text="התחבר" OnClick="BtnLogin_Click" /></div> <br />
               <asp:Literal ID="Ltlmsg" runat="server" />  <!-- ליטרל זה סוג של שומר מקום שמאפשר הזרקת תוכן מהשרת לעמוד    -->
           </div>

    </div >
</div>
        
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
