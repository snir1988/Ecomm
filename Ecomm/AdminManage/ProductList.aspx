﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Ecomm.AdminManage.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/dataTables.bootstrap4.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1> ניהול מוצרים</h1>
    <table class="table table-borderless table-hover" id="MainTbl">
        <thead>
            <tr>
                <th>קוד</th>
                <th>שם מוצר</th>
                <th>מחיר</th>
                <th>תמונה</th>
                <th>ניהול</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RptProds" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Pid") %></td>
                        <td><%# Eval("Pname") %></td>
                        <td><%# Eval("Price") %></td>
                        <td><img src="/uploads/prods/img/<%#Eval("Picname") %>" width="75" class="avatar-img rounded-circle" /></td>
                        <td>
                            <button class="btn btn-sm dropdown-toggle more-horizontal" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <span class="text-muted sr-only">ניהול</span>
                            </button>
                            <div class="dropdown-menu dropdown-menu-right">
                                <a class="dropdown-item" href='<%# "ProductAddEdit.aspx?Pid=" + Eval("Pid") %>'>עריכה</a>

                                <a class="dropdown-item" href="#">מחיקה</a>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
    <script src='js/jquery.dataTables.min.js'></script>
    <script src='js/dataTables.bootstrap4.min.js'></script>
    <script>
        $('#MainTbl').DataTable(
            {
                 autoWidth: true,
                 "lengthMenu": [
                   [16, 32, 64, -1],
                     [16, 32, 64, "All"]
                    ]
  });
</script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">

</asp:Content>
