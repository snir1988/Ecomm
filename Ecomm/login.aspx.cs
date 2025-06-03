using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnLogin_Click(object sender, EventArgs e)
		{
			string Email = TxtEmail.Text;
			string Pass = TextPass.Text;
			Users us = Users.CheckLogin(Email, Pass);
			if (us != null)
			{
				Session["Login"] = us;
				Response.Redirect("/AdminManage");
			}
			else
			{
				
			}
		}
	}
}