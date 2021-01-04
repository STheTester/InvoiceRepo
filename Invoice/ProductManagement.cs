using System;
using System.Drawing;
using System.Windows.Forms;

namespace Invoice
{
    public partial class frmProductManagement : Form
    {
        private int _productNumber;
        private int _orderNumber;
        private int _OrderDetailsNumber;
        private string _pNum = "";
        private string _oNum = "";
        private string _oDetailsNum = "";
        private string _emptyTextBox = "Please enter all values";

        OrderFunctionality order = new OrderFunctionality();
        public frmProductManagement()
        {
            InitializeComponent();
            convertPNumber();
            convertOrderNumber();
            convertOrderDetailsNumber();
        }
        //Change format for product number
        private void convertPNumber()
        {
            _pNum = "P" + string.Format("{0:0000}", _productNumber);
            txtProductNumber.Text = _pNum;
            _productNumber++;
        }
        //clear the product boxes
        private void clearProductBoxes()
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProNumber.Text = "";
        }
        //Add new product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(txtProductNumber.Text == "" || txtProductName.Text =="")
            {
                MessageBox.Show(_emptyTextBox);
            }
            else
            {
                try
                {
                    convertPNumber();
                    string num = _pNum;
                    string name = txtProductName.Text;
                    decimal price = Convert.ToDecimal(txtProductPrice.Text);
                    Product p = new Product(num, name, price);
                    order.NewProduct(p);
                    clearProductBoxes();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
        //Return product details using product number
        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            if (txtProNumber.Text == "") 
            {
                MessageBox.Show(_emptyTextBox);

            }
            else
            {
                try
                {
                    string num = txtProNumber.Text;
                    int i = order.ProductInformation(num);
                    string n = order.ProductName(i);
                    string j = Convert.ToString(order.ProductPrice(i));
                    txtProductName.Text = n;
                    txtProductPrice.Text = j;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throwProductNotFound();
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearOrderBoxes();
            clearProductBoxes();
            clearOrderDetailsBoxes();
        }


        //Stop someone from entering a non decimal value
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

        //Order Functionality
        private void convertOrderNumber()
        {
            _oNum = "REF" + string.Format("{0:-000-000}", _orderNumber);
            txtOrderNumber.Text = _oNum;
            _orderNumber++;
        }

        private void convertOrderDetailsNumber()
        {
            _oDetailsNum = "REF" + string.Format("{0:-000-000-00}", _OrderDetailsNumber);
            txtOrderDetailsNumber.Text = _oDetailsNum;
            _OrderDetailsNumber++;
        }

        private void clearOrderBoxes()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            txtOrderDate.Text = "";
        }

        private void clearOrderDetailsBoxes()
        {
            txtProdNum.Text = "";
            txtQuantity.Text = "";
            txtODetailsNum.Text = "";
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text==""
                || txtLastName.Text=="" 
                || txtAddress.Text==""
                || txtTown.Text==""
                || txtCounty.Text==""
                || txtPostcode.Text==""
                || txtOrderDate.Text=="")
            {
                MessageBox.Show(_emptyTextBox);
            }
            else
            {
                try
                {
                    //Add order to array
                    convertOrderNumber();
                    string orderNumber = _oNum;
                    string customerFirstName = txtFirstName.Text;
                    string customerLastName = txtLastName.Text;
                    string address = txtAddress.Text;
                    string town = txtTown.Text;
                    string county = txtCounty.Text;
                    string postcode = txtPostcode.Text;
                    string orderDate = txtOrderDate.Text;
                    Order o = new Order(orderNumber, customerFirstName, customerLastName, address, town, county, postcode, orderDate);
                    order.NewOrder(o);
                    clearOrderBoxes();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            if(txtOrderNum.Text == "")
            {
                MessageBox.Show(_emptyTextBox);

            }
            else
            {
                try
                {
                    //get orderInformation from ref number
                    string num = txtOrderNum.Text;
                    int i = order.OrderInformation(num);
                    string a = order.OrderFirstName(i);
                    string b = order.OrderLastName(i);
                    string c = order.OrderAddress(i);
                    string d = order.OrderTown(i);
                    string f = order.OrderCounty(i);
                    string g = order.OrderPostcode(i);
                    string h = order.OrderOrderDate(i);
                    //set values
                    txtFirstName.Text = a;
                    txtLastName.Text = b;
                    txtAddress.Text = c;
                    txtTown.Text = d;
                    txtCounty.Text = f;
                    txtPostcode.Text = g;
                    txtOrderDate.Text = h;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throwOrderNotFound();
                }
            }
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            if (txtProdNum.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show(_emptyTextBox);
            }
            else
            {
                try
                {
                    //Add order to array
                    convertOrderDetailsNumber();
                    string orderDetailsNumber = _oDetailsNum;
                    string orderNumber = _oNum;
                    string productNumber = txtProdNum.Text;
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    
                    OrderDetails od = new OrderDetails(orderDetailsNumber, orderNumber, productNumber, quantity);
                    order.NewOrderDetails(od);
                    clearOrderDetailsBoxes();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
        //try to return product ordered from order details
        private void btnGetOrderDetails_Click(object sender, EventArgs e)
        {
            if (txtODetailsNum.Text == "")
            {
                MessageBox.Show(_emptyTextBox);
            }
            else
            {
                try
                {
                    //get order details
                    string num = txtODetailsNum.Text;
                    int i = order.OrderProducts(num);
                    string a = order.OrderProductNumber(i);
                    string b = Convert.ToString(order.OrderQuantity(i));
                    
                    //add order details to form
                    txtProdNum.Text = a;
                    txtQuantity.Text = b;
                }

                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throwOrderDetailsNotFound();
                }
            }

        }
        //try to return order total from order details
        //not finished
        private void btnGetOrderTotal_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtODetailsNum.Text;
                int b = order.OrderProducts(a);
                int quantity = order.OrderQuantity(b);

                string orderDetailsNum = order.OrderDetailsOrderNumber(b);
                int f = order.ProductInformation(orderDetailsNum);
                decimal price = order.ProductPrice(f);

                decimal total = quantity * price;

                lblTotal.Text = Convert.ToString(total);
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throwOrderDetailsNotFound();
            }
        }
        //Only allow ints in quantity box
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Throw error when product
        private void throwProductNotFound()
        {
            MessageBox.Show("Product not Found, check product number and retry");
        }
        private void throwOrderNotFound()
        {
            MessageBox.Show("Order not Found, check order number and retry");
        }
        private void throwOrderDetailsNotFound()
        {
            MessageBox.Show("Order details not Found, check order details number and retry");
        }

    }
}
