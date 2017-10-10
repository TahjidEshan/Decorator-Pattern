namespace DesignPatternAssignment4
{
    enum Types { Laptop, Desktop, Mobile };
    interface IDokanProduct
    {
        string ProductName { get; }
        double BaseProductPrice { get; }
        double AddOnPrice { get; }
        double ProductSize { get; }
        int ProductType { get; }
    }
}
