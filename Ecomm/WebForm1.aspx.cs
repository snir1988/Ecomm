using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Ecomm
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int Pid = 4;
			Product Tmmp = new Product();
			Product Tmp2 = Product.GetByID(Pid);
		}
	}
}