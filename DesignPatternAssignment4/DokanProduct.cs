namespace DesignPatternAssignment4
{
    abstract class DokanProduct : IDokanProduct
    {
        public abstract string ProductName { get; }
        public abstract double BaseProductPrice { get; }
        public abstract double AddOnPrice { get; }
        public abstract double ProductSize { get; }
        public abstract int ProductType { get; }
    }
}
