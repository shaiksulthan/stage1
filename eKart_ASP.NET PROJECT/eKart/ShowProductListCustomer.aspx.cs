using Dao;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eKart
{
    public partial class ShowProductListCustomer : Page
    {
        //Commented line shown below is to use the List data instead of database hit
        //CartDaoCollection cartDao = new CartDaoCollection();
        //ProductDaoCollection productDao = new ProductDaoCollection();

        CartDaoSql cartDao = new CartDaoSql();        
        ProductDaoSql productDao = new ProductDaoSql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdProducts.DataSource = productDao.GetProductListCustomer();
                grdProducts.DataBind();
            }
        }

        protected void grdProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("Add"))
            {
                int gridViewRowIndex = int.Parse(e.CommandArgument.ToString());
                string productId = grdProducts.Rows[gridViewRowIndex].Cells[0].Text;
                cartDao.AddCartItem(1, long.Parse(productId));
                Response.Redirect("AddToCart.aspx");
            }
        }
    }
}