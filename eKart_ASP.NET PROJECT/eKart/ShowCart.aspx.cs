using Dao;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eKart
{
    public partial class ShowCart : Page
    {
        //Commented line shown below is to use the List data instead of database hit
        //CartDaoCollection cartDao = new CartDaoCollection();
        CartDaoSql cartDao = new CartDaoSql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void grdProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("Delete"))
            {
                int gridViewRowIndex = int.Parse(e.CommandArgument.ToString());
                string productId = grdProducts.Rows[gridViewRowIndex].Cells[0].Text;
                cartDao.RemoveCartItem(1, long.Parse(productId));
            }
        }

        protected void grdProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            try
            {
                grdProducts.DataSource = cartDao.GetAllCartItem(1).ProductList;
                grdProducts.DataBind();
            }
            catch (CartEmptyException /*cartEmptyEx*/)
            {
                Response.Redirect("CartEmpty.aspx");
            }
        }
    }
}