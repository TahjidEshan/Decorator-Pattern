using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            IDokanProduct product = new ActualProduct();
            VatDecorator vat = new VatDecorator(product);
            Console.WriteLine(vat.BaseProductPrice);
            Console.WriteLine(vat.ProductName);
            Console.WriteLine(vat.ProductPrice);
            ShippingDecorator shipping = new ShippingDecorator(vat);
            Console.WriteLine(shipping.ProductName);
            Console.WriteLine(shipping.ProductPrice);
            //            Console.WriteLine(shipping.BaseProductPrice);
            TaxDecorator tax = new TaxDecorator(shipping, 5);
            Console.WriteLine(tax.ProductName);
            Console.WriteLine(tax.ProductPrice);
            //          Console.WriteLine(tax.BaseProductPrice);
            DiscountDecorator free = new DiscountDecorator(tax);
            Console.WriteLine(free.ProductName);
            Console.WriteLine(free.ProductPrice);
            Console.ReadLine();
        }
    }
}
