<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserAddEdit.aspx.cs" Inherits="Ecomm.AdminManage.UserAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">

    <h2 class="page-title">הוספה/עריכת משתמש</h2>
    <p class="text-muted">יש להזין את פרטי המשתמש ולבצע שמירה</p>

    <div class="card-deck">
        <div class="card shadow mb-4">
            <div class="card-header">
                <strong class="card-title">פרטי המשתמש</strong>
            </div>

            <asp:HiddenField ID="HidUid" runat="server" Value="-1" />

            <div class="card-body">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtEmail">אימייל</label>
                        <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="נא הזינו אימייל" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtPass">סיסמה</label>
                        <asp:TextBox ID="TxtPass" runat="server" CssClass="form-control" placeholder="נא הזינו סיסמה" TextMode="Password" />
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtFullName">שם מלא</label>
                        <asp:TextBox ID="TxtFullName" runat="server" CssClass="form-control" placeholder="נא הזינו שם מלא" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtAdress">כתובת</label>
                        <asp:TextBox ID="TxtAdress" runat="server" CssClass="form-control" placeholder="נא הזינו כתובת" />
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtPhone">טלפון</label>
                        <asp:TextBox ID="TxtPhone" runat="server" CssClass="form-control" placeholder="נא הזינו טלפון" />
                    </div>
                </div>

                <asp:Button ID="BtnSave" Text="שמירה" runat="server" CssClass="btn btn-primary" OnClick="BtnSave_Click" />
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>

