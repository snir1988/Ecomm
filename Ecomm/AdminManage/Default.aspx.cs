﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm.AdminManage
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["Login"] == null) //// במידה ולא קיים סשן של זהות המשתמש
				Response.Redirect("/Login.aspx"); /// העברה לעמוד ההתחברות
			Users us = (Users)Session["Login"];
			LtlUser.Text = $"שלום {us.FullName}";
		}
	}
}