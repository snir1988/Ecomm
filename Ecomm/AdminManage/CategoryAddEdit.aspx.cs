using System;
using BLL;

namespace Ecomm.AdminManage
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strId = Request["Cid"];
                if (!string.IsNullOrEmpty(strId))
                {
                    int id = int.Parse(strId);
                    Category c = Category.GetByID(id);
                    if (c != null)
                    {
                        HidCid.Value = c.Cid.ToString();
                        TxtName.Text = c.Cname;
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Category c = new Category()
            {
                Cid = int.Parse(HidCid.Value),
                Cname = TxtName.Text,
                Added = DateTime.Now
            };

            Category.Save(c);
            Response.Redirect("CategoryList.aspx");
        }
    }
}
