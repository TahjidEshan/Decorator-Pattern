namespace DesignPatternAssignment4
{
    class DiscountDecorator : Decorator
    {
        public DiscountDecorator(IDokanProduct product) : base(product)
        {
            this.decoratorName = "Free Decorator";
            AddOnPrice = _dokanProduct.AddOnPrice;
            BaseProductPrice = 0;
        }
    }
}
