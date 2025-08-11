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
                DDLCategory.DataSource = Category.GetAll();
                DDLCategory.DataValueField = "Cid";
                DDLCategory.DataTextField = "Cname";
                DDLCategory.DataBind();
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
						DDLCategory.SelectedValue = Tmp.Cid+"";


                    }
                    else
					{

					}
				}
			}
		}
		protected void BtnSave_Click(object sender, EventArgs e)
		{
			string Picname = "";
			if (UplPic.HasFile)
			{
				string FileName = GlobFunc.GetRandStr(8);
				int ind = UplPic.FileName.LastIndexOf('.');
				string Ext = UplPic.FileName.Substring(ind);
				Picname = FileName + Ext;
				UplPic.SaveAs(Server.MapPath("/uploads/prods/img/" + Picname));
				TxtPicname.Text = Picname;
			}
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
            Application["Prods"] = Product.GetAll();
			Response.Redirect("ProductList.aspx");
		}
	}
}