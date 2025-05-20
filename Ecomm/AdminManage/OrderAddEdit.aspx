<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="OrderAddEdit.aspx.cs" Inherits="Ecomm.AdminManage.OrderAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2>הוספה / עריכת הזמנה</h2>
    <asp:HiddenField ID="HidOid" runat="server" Value="-1" />

    <div class="form-group">
        <label>בחר משתמש:</label>
        <asp:DropDownList ID="DDLUsers" runat="server" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label>סכום כולל:</label>
        <asp:TextBox ID="TxtTotal" runat="server" CssClass="form-control" />
    </div>

    <asp:Button ID="BtnSave" runat="server" Text="שמירה" CssClass="btn btn-success" OnClick="BtnSave_Click" />
</asp:Content>
