namespace Invoice
{
    public class Product
    {
        private string _productNumber;
        private string _productName;

        private decimal _productPrice;
        //Constructor with no params
        public Product()
        {
            _productNumber = "P0000";
            _productName = "Name";
            _productPrice = 0.00m;
        }
        //Constructor with params
        public Product(string productNumber, string productName, decimal productPrice)
        {
            setProductNumber(productNumber);
            setProductName(productName);
            setProductPrice(productPrice);
        }
        //getters and setters
        public string getProductNumber()
        {
            return _productNumber;
        }

        public void setProductNumber(string productNumber)
        {
            this._productNumber = productNumber;
        }

        public string getProductName()
        {
            return _productName;
        }

        public void setProductName(string productName)
        {
            this._productName = productName;
        }

        public decimal getProductPrice()
        {
            return _productPrice;
        }

        public void setProductPrice(decimal productPrice)
        {
            this._productPrice = productPrice;
        }

    }
}
