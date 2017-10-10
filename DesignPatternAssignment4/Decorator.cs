using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment4
{
    abstract class Decorator : IDokanProduct
    {
        protected IDokanProduct _dokanProduct;
        public double BaseProductPrice { get; set; }
        protected string decoratorName = "";
        protected double addOnPrice = 0;
        protected Decorator(IDokanProduct value)
        {
            _dokanProduct = value;
            this.BaseProductPrice = _dokanProduct.BaseProductPrice;
        }
        public string ProductName
        {
            get
            {
                return _dokanProduct.ProductName + " " + this.decoratorName;
            }
        }
        public double AddOnPrice
        {
            get
            {
                return addOnPrice;
            }
            set
            {
                addOnPrice = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return this.BaseProductPrice + this.addOnPrice;
            }
        }
        public double ProductSize
        {
            get
            {
                return _dokanProduct.ProductSize;
            }
        }
        public int ProductType
        {
            get
            {
                return _dokanProduct.ProductType;
            }
        }
    }
}
