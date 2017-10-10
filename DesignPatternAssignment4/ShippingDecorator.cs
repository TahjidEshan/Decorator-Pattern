using System;

namespace DesignPatternAssignment4
{
    class ShippingDecorator : Decorator
    {
        public ShippingDecorator(IDokanProduct product) : base(product)
        {
            this.decoratorName = "Shipping Decorator";
            this.AddOnPrice = _dokanProduct.AddOnPrice + GetShippingCost();
        }
        private double GetShippingCost()
        {
            Console.WriteLine("Enter Distance in KM");
            double distance = Convert.ToDouble(Console.ReadLine());
            return distance * 2;
        }

    }
}
