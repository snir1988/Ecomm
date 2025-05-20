using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace Ecomm.AdminManage
{
	public partial class ProductAddEdit : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string Pid = Request["Pid"] +""; // קבלת הפרמטר של קוד המוצר בטעינה הראשונית של הדף
				if (Pid!= "")
				{
					Product Tmp = Product.GetByID(int.Parse(Pid));// שליפת המוצר עם קוד המוצר שקיבלנו
					if (Tmp != null)
					{
                        TxtPName.Text = Tmp.Pname;
                        TxtPicname.Text = Tmp.Picname;
                        TextPdesc.Text = Tmp.Pdesc;
                        TextPrice.Text = Tmp.Price + "";
						DDLStatus.SelectedValue = Tmp.Status + "";
                        HidPid.Value = Tmp.Pid + "";


                    }
                    else
					{

					}
				}
			}
		}
		protected void BtnSave_Click(object sender, EventArgs e)
		{
			Product Tmp = new Product()
			{
				Pid= int.Parse(HidPid.Value),
				Picname=TxtPicname.Text,
				Pdesc= TextPdesc.Text,
				Price=float.Parse(TextPrice.Text),
				Pname= TxtPName.Text,
				Status=int.Parse(DDLStatus.SelectedValue)
            };
			Tmp.save();
			Response.Redirect("ProductList.aspx");
		}
	}
}