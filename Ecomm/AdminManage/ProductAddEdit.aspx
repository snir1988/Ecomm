<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductAddEdit.aspx.cs" Inherits="Ecomm.AdminManage.ProductAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">

     <h2 class="page-title">הוספה/עריכת מוצר</h2>
 <p class="text-muted">יש להזין את פרטי המוצר המבוקש ולבצע שמירה</p>
 <div class="card-deck">
   <div class="card shadow mb-4">
     <div class="card-header">
       <strong class="card-title">פרטי המוצר</strong>
     </div>
     <div class="card-body">
       
         <div class="form-row">
           <div class="form-group col-md-6">
             <label for="TxtPName">שם המוצר</label>
               <asp:TextBox ID="TxtPName" runat="server" class="form-control" placeholder="נא הזינו שם מוצר" />
           </div>
           <div class="form-group col-md-6">
             <label for="TextPrice">מחיר</label>
                 <asp:TextBox ID="TextPrice" runat="server" class="form-control" placeholder="נא הזינו מחיר" />

           </div>
         </div>

         <div class="form-row">
  <div class="form-group col-md-6">
    <label for="TxtPicname">תמונת המוצר</label>
      <asp:TextBox ID="TxtPicname" runat="server" class="form-control" placeholder="נא הזינו את שם התמונה" />
  </div>
  <div class="form-group col-md-6">
    <label for="TextPdesc">תיאור</label>
        <asp:TextBox ID="TextPdesc" runat="server" class="form-control"Textmode="MultiLine" Columns="40" Rows="10" placeholder="נא הזינו תיאור המוצר" />

  </div>
</div>
        
         <asp:Button ID="BtnSave" Text="שמירה" runat="server" class="btn btn-primary" />
       
     </div>
   </div>
   
 </div> <!-- / .card-desk-->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
