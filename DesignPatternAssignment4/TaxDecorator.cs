namespace DesignPatternAssignment4
{
    class TaxDecorator : Decorator
    {
        public TaxDecorator(IDokanProduct product, double taxPercentage) : base(product)
        {
            this.decoratorName = "Tax Decorator";
            this.AddOnPrice = _dokanProduct.AddOnPrice + GetTax(_dokanProduct.BaseProductPrice, taxPercentage);
        }
        private double GetTax(double price, double percentage)
        {
            return (price * percentage) / 100;
        }

    }
}
