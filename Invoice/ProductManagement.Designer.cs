
namespace Invoice
{
    partial class frmProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProNumber = new System.Windows.Forms.TextBox();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOrderDetailsTotal = new System.Windows.Forms.Label();
            this.btnGetOrderDetails = new System.Windows.Forms.Button();
            this.txtODetailsNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderDetailsNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddOrderDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGetOrderTotal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(10, 37);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(84, 13);
            this.lblProductNumber.TabIndex = 0;
            this.lblProductNumber.Text = "Product Number";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(10, 107);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(10, 71);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(13, 136);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Number";
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Enabled = false;
            this.txtProductNumber.Location = new System.Drawing.Point(119, 37);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(100, 20);
            this.txtProductNumber.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(119, 64);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(119, 100);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 7;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress_1);
            // 
            // txtProNumber
            // 
            this.txtProNumber.Location = new System.Drawing.Point(119, 170);
            this.txtProNumber.Name = "txtProNumber";
            this.txtProNumber.Size = new System.Drawing.Size(100, 20);
            this.txtProNumber.TabIndex = 8;
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Location = new System.Drawing.Point(13, 208);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(75, 23);
            this.btnGetProduct.TabIndex = 9;
            this.btnGetProduct.Text = "Get Product";
            this.btnGetProduct.UseVisualStyleBackColor = true;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(248, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear all details from form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(27, 362);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(75, 23);
            this.btnGetOrder.TabIndex = 41;
            this.btnGetOrder.Text = "Get Order";
            this.btnGetOrder.UseMnemonic = false;
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Order Number";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(131, 315);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(129, 20);
            this.txtOrderNum.TabIndex = 39;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(131, 229);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(129, 20);
            this.txtOrderDate.TabIndex = 38;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(131, 203);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(129, 20);
            this.txtPostcode.TabIndex = 37;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(131, 177);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(129, 20);
            this.txtCounty.TabIndex = 36;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(131, 146);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(129, 20);
            this.txtTown.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 20);
            this.txtAddress.TabIndex = 34;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(129, 20);
            this.txtLastName.TabIndex = 33;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtFirstName.TabIndex = 32;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Enabled = false;
            this.txtOrderNumber.Location = new System.Drawing.Point(131, 36);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(129, 20);
            this.txtOrderNumber.TabIndex = 31;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(27, 268);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 30;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(29, 177);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 29;
            this.lblCounty.Text = "County";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(29, 206);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 28;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(29, 236);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 27;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(29, 147);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 23;
            this.lblTown.Text = "Town";
            this.lblTown.UseMnemonic = false;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(29, 36);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNumber.TabIndex = 22;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 109);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 13);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Order Total";
            // 
            // lblOrderDetailsTotal
            // 
            this.lblOrderDetailsTotal.AutoSize = true;
            this.lblOrderDetailsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblOrderDetailsTotal.Location = new System.Drawing.Point(186, 91);
            this.lblOrderDetailsTotal.Name = "lblOrderDetailsTotal";
            this.lblOrderDetailsTotal.Size = new System.Drawing.Size(67, 31);
            this.lblOrderDetailsTotal.TabIndex = 45;
            this.lblOrderDetailsTotal.Text = "0.00";
            // 
            // btnGetOrderDetails
            // 
            this.btnGetOrderDetails.Location = new System.Drawing.Point(25, 62);
            this.btnGetOrderDetails.Name = "btnGetOrderDetails";
            this.btnGetOrderDetails.Size = new System.Drawing.Size(129, 23);
            this.btnGetOrderDetails.TabIndex = 44;
            this.btnGetOrderDetails.Text = "Get Order Details";
            this.btnGetOrderDetails.UseMnemonic = false;
            this.btnGetOrderDetails.UseVisualStyleBackColor = true;
            this.btnGetOrderDetails.Click += new System.EventHandler(this.btnGetOrderDetails_Click);
            // 
            // txtODetailsNum
            // 
            this.txtODetailsNum.Location = new System.Drawing.Point(153, 32);
            this.txtODetailsNum.Name = "txtODetailsNum";
            this.txtODetailsNum.Size = new System.Drawing.Size(100, 20);
            this.txtODetailsNum.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Order Details Number";
            // 
            // txtOrderDetailsNumber
            // 
            this.txtOrderDetailsNumber.Enabled = false;
            this.txtOrderDetailsNumber.Location = new System.Drawing.Point(153, 35);
            this.txtOrderDetailsNumber.Name = "txtOrderDetailsNumber";
            this.txtOrderDetailsNumber.Size = new System.Drawing.Size(120, 20);
            this.txtOrderDetailsNumber.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Order Details Number";
            // 
            // txtProdNum
            // 
            this.txtProdNum.Location = new System.Drawing.Point(153, 66);
            this.txtProdNum.Name = "txtProdNum";
            this.txtProdNum.Size = new System.Drawing.Size(120, 20);
            this.txtProdNum.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Product Number";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 92);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 51;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(153, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 52;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // btnAddOrderDetails
            // 
            this.btnAddOrderDetails.Location = new System.Drawing.Point(25, 119);
            this.btnAddOrderDetails.Name = "btnAddOrderDetails";
            this.btnAddOrderDetails.Size = new System.Drawing.Size(106, 23);
            this.btnAddOrderDetails.TabIndex = 53;
            this.btnAddOrderDetails.Text = "Add Order Details";
            this.btnAddOrderDetails.UseVisualStyleBackColor = true;
            this.btnAddOrderDetails.Click += new System.EventHandler(this.btnAddOrderDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnGetOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOrderNum);
            this.panel1.Controls.Add(this.txtOrderDate);
            this.panel1.Controls.Add(this.txtPostcode);
            this.panel1.Controls.Add(this.txtCounty);
            this.panel1.Controls.Add(this.txtTown);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Controls.Add(this.lblCounty);
            this.panel1.Controls.Add(this.lblPostcode);
            this.panel1.Controls.Add(this.lblOrderDate);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblTown);
            this.panel1.Controls.Add(this.lblOrderNumber);
            this.panel1.Location = new System.Drawing.Point(234, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 446);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnAddOrderDetails);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.txtProdNum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtOrderDetailsNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(515, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 205);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btnGetOrderTotal);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblOrderDetailsTotal);
            this.panel3.Controls.Add(this.btnGetOrderDetails);
            this.panel3.Controls.Add(this.txtODetailsNum);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(515, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 193);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.btnGetProduct);
            this.panel4.Controls.Add(this.txtProNumber);
            this.panel4.Controls.Add(this.txtProductPrice);
            this.panel4.Controls.Add(this.txtProductName);
            this.panel4.Controls.Add(this.txtProductNumber);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAddProduct);
            this.panel4.Controls.Add(this.lblProductName);
            this.panel4.Controls.Add(this.lblProductPrice);
            this.panel4.Controls.Add(this.lblProductNumber);
            this.panel4.Location = new System.Drawing.Point(-1, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 446);
            this.panel4.TabIndex = 57;
            // 
            // btnGetOrderTotal
            // 
            this.btnGetOrderTotal.Location = new System.Drawing.Point(25, 142);
            this.btnGetOrderTotal.Name = "btnGetOrderTotal";
            this.btnGetOrderTotal.Size = new System.Drawing.Size(129, 23);
            this.btnGetOrderTotal.TabIndex = 47;
            this.btnGetOrderTotal.Text = "Get Order Total";
            this.btnGetOrderTotal.UseMnemonic = false;
            this.btnGetOrderTotal.UseVisualStyleBackColor = true;
            this.btnGetOrderTotal.Click += new System.EventHandler(this.btnGetOrderTotal_Click);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Name = "frmProductManagement";
            this.Text = "ProductManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProNumber;
        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOrderDetailsTotal;
        private System.Windows.Forms.Button btnGetOrderDetails;
        private System.Windows.Forms.TextBox txtODetailsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderDetailsNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddOrderDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGetOrderTotal;
    }
}