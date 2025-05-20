using System;
using System.Collections.Generic;
using BLL;

namespace Ecomm.AdminManage
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Order> lst = Order.GetAll();
                RptOrders.DataSource = lst;
                RptOrders.DataBind();
            }
        }
    }
}
