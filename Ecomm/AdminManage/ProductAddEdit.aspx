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
       <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
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
<asp:TextBox ID="TextPdesc" runat="server" TextMode="MultiLine" Columns="40" Rows="10" CssClass="form-control" />

  </div>
               <div class="form-group col-md-4">
                   <div class="from-group mb-3">
                <label for="DDLStatus">סטטאוס המוצר</label>
        <asp:DropDownList ID="DDLStatus" runat="server" CssClass="form-control">
                       <asp:ListItem Text="פעיל" Value="1"></asp:ListItem>
                       <asp:ListItem Text="לא פעיל" Value="0"></asp:ListItem>
            </asp:DropDownList>
    </div>
  </div>
</div>
        
         <asp:Button ID="BtnSave" Text="שמירה" runat="server" class="btn btn-primary" OnClick="BtnSave_Click" CssClass="btn btn-primary" />
       
     </div>
   </div>
   
 </div> <!-- / .card-desk-->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
