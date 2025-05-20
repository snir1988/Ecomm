<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Ecomm.AdminManage.CategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>ניהול קטגוריות</h1>
    <a class="btn btn-primary mb-3" href="CategoryAddEdit.aspx">הוספת קטגוריה</a>
    <table class="table table-borderless table-hover" id="MainTbl">
        <thead>
            <tr>
                <th>מספר</th>
                <th>שם קטגוריה</th>
                <th>תאריך הוספה</th>
                <th>ניהול</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RptCategories" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Cid") %></td>
                        <td><%# Eval("Cname") %></td>
                        <td><%# Eval("Added", "{0:yyyy-MM-dd}") %></td>
                        <td>
                            <a class="btn btn-sm btn-secondary" href='<%# "CategoryAddEdit.aspx?Cid=" + Eval("Cid") %>'>עריכה</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
