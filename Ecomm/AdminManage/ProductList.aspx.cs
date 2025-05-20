using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Ecomm.AdminManage
{
	public partial class ProductList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
                List<Product> Lst = Product.GetAll();

                RptProds.DataSource = Lst;
				RptProds.DataBind();

                Page.DataBind();
            }
        }
	}
}