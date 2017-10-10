namespace DesignPatternAssignment4
{
    class ActualProduct : DokanProduct
    {
        private string _productName = "HP Probook 4540s";
        private double _productPrice = 50000;
        private double _productSize = 15;
        private int _productType = (int)Types.Laptop;
        public override string ProductName
        {
            get
            {
                return _productName;
            }
        }
        public override double BaseProductPrice
        {
            get
            {
                return _productPrice;
            }
        }
        public override double AddOnPrice { get; }
        public override double ProductSize
        {
            get
            {
                return _productSize;
            }
        }
        public override int ProductType
        {
            get
            {
                return _productType;
            }
        }
    }
}
