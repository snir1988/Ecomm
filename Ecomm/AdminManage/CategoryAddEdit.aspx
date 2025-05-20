<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryAddEdit.aspx.cs" Inherits="Ecomm.AdminManage.CategoryAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2>הוספה / עריכת קטגוריה</h2>
    <asp:HiddenField ID="HidCid" runat="server" Value="-1" />

    <div class="form-group">
        <label>שם קטגוריה:</label>
        <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" />
    </div>

    <asp:Button ID="BtnSave" runat="server" Text="שמירה" CssClass="btn btn-success" OnClick="BtnSave_Click" />
</asp:Content>
