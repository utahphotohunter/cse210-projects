class Product
{
    private List<string> _product = new List<string> {};
    private string _productId;
    private string _name;
    private int _unitPrice;
    private int _quantity;
// ----------------------------------------------
    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetPrice(int unitPrice)
    {
        _unitPrice = unitPrice;
    }

    public int GetPrice()
    {
        return _unitPrice;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
// ----------------------------------------------
    public void MakeProduct(string productId, string name, int unitPrice, int quantity)
    {
        string unitPriceString = unitPrice.ToString();
        string quantityString = quantity.ToString();

        _product.Add(productId);
        _product.Add(name);
        _product.Add(unitPriceString);
        _product.Add(quantityString);
    }

    public List<string> GetProduct()
    {
        return _product;
    }












}