using System;
using System.Windows.Forms;

namespace Invoice
{
    public partial class ProductManagement : Form
    {
        int pNumber = 0;
        string pNum = "";
        OrderFunctionality order = new OrderFunctionality();
        public ProductManagement()
        {
            InitializeComponent();
            convertPNumber();
            
        }
        private void convertPNumber()
        {
            pNum = "P" + string.Format("{0:0000}", pNumber);
            txtProductNumber.Text = pNum;
            pNumber++;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            convertPNumber();
            string num = pNum;
            string name = txtProductName.Text;
            decimal price = Convert.ToDecimal(txtProductPrice.Text);
            Product p = new Product(num, name, price);
            order.NewProduct(p);
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            string num = txtProNumber.Text;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProNumber.Text = "";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtProductPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
