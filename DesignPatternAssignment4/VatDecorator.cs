namespace DesignPatternAssignment4
{
    class VatDecorator : Decorator
    {
        public VatDecorator(IDokanProduct product) : base(product)
        {
            this.decoratorName = "Vat Decorator";
            this.AddOnPrice = _dokanProduct.AddOnPrice + GetVat();
        }
        private double GetVat()
        {
            int type = this._dokanProduct.ProductType;
            double vat = 0;
            switch (type)
            {
                case (int)Types.Desktop:
                    vat = 20;
                    break;
                case (int)Types.Laptop:
                    vat = 15;
                    break;
                case (int)Types.Mobile:
                    vat = 5;
                    break;
            }
            return vat;
        }
    }
}
