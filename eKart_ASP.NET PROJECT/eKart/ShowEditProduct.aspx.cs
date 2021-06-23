using Dao;
using Model;
using System;

namespace eKart
{
    public partial class ShowEditProduct : System.Web.UI.Page
    {
        //Commented line shown below is to use the List data instead of database hit
        //ProductDaoCollection productDao = new ProductDaoCollection();
        ProductDaoSql productDao = new ProductDaoSql();
        private long _productId = -1;

        public long ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["ProductId"] != null)
            {
                string strProductId = Request.QueryString["ProductId"].ToString();
                if (!strProductId.Equals(string.Empty))
                {
                    ProductId = long.Parse(strProductId);
                    Product product = productDao.GetProduct(ProductId);
                    if (product != null)
                    {
                        SetProductData(product);
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(Request.QueryString["ProductId"].ToString());
            product.Title = txtTitle.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.FreeDelivery = chkFreeDelivery.Checked;
            if (radInStockYes.Checked == true)
            {
                product.InStock = true;
            }
            else
            {
                product.InStock = false;
            }
            product.Category = ddlCategory.Items[ddlCategory.SelectedIndex].Text;
            product.DateOfExpiry = Convert.ToDateTime(txtDateOfExpiry.Text);

            productDao.ModifyProduct(product);

            Response.Redirect("ShowProductListAdmin.aspx");
        }

        private void SetProductData(Product product)
        {
            txtTitle.Text = product.Title;
            txtPrice.Text = product.Price.ToString();
            if (product.InStock == true)
            {
                radInStockYes.Checked = true;
            }
            else
            {
                radInStockNo.Checked = true;
            }
            txtDateOfExpiry.Text = product.DateOfExpiry.ToString("yyyy-MM-dd");
            if (ddlCategory.Items.FindByText(product.Category) != null)
            {
                ddlCategory.Items.FindByText(product.Category).Selected = true;
            }
            chkFreeDelivery.Checked = product.FreeDelivery;
        }
    }
}