<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="Ecomm.AdminManage.OrderList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" />
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>ניהול הזמנות</h1>
    <a class="btn btn-primary mb-3" href="OrderAddEdit.aspx">הוספת הזמנה</a>
    <table class="table table-borderless table-hover" id="MainTbl">
        <thead>
            <tr>
                <th>קוד</th>
                <th>משתמש</th>
                <th>תאריך</th>
                <th>סכום</th>
                <th>ניהול</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RptOrders" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Oid") %></td>
                        <td><%# Eval("Uid") %></td>
                        <td><%# Eval("OrderDate", "{0:yyyy-MM-dd}") %></td>
                        <td><%# Eval("Total") %></td>
                        <td>
                            <a href='<%# "OrderAddEdit.aspx?Oid=" + Eval("Oid") %>' class="btn btn-sm btn-secondary">עריכה</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
