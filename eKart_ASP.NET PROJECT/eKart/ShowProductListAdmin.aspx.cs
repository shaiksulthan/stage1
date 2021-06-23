using Dao;
using System;
using System.Web.UI.WebControls;

namespace eKart
{
    public partial class ShowProductListAdmin : System.Web.UI.Page
    {
        //Commented line shown below is to use the List data instead of database hit
        //ProductDaoCollection productDao = new ProductDaoCollection();
        ProductDaoSql productDao = new ProductDaoSql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdProducts.DataSource = productDao.GetProductListAdmin();
                grdProducts.DataBind();
            }
        }

        protected void grdProducts_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = grdProducts.Rows[e.NewEditIndex];
            string productId = row.Cells[0].Text;
            Response.Redirect("ShowEditProduct.aspx?ProductId=" + productId);
        }
    }
}