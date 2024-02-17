class Order
{
    private List<List<string>> _orderContent = new List<List<string>> {};
    private string _shippingLabel;
    private string _customer;
    private float _shippingPrice;
// ----------------------------------------------
    public void SetShippingLabel(string label)
    {
        _shippingLabel = label;
    }

    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

    public void SetCustomer(string customer)
    {
        _customer = customer;
    }

    public string GetCustomer()
    {
        return _customer;
    }
// ----------------------------------------------
    public void AddToOrder(List<string> product)
    {
        _orderContent.Add(product);
    }

    public void PrintPackingLabel(List<List<string>> orderContent)
    {
        Console.WriteLine("Packing Label\n");
        Console.WriteLine("Contents:");
        foreach (List<string> product in orderContent)
        {
            string productId = product[0];
            string productName = product[1];
            string productUnitPrice = product[2];
            string productQuantity = product[3];

            string packingLabelContents = $"ID: {productId} \nName: {productName} \nUnit Price: {productUnitPrice} \nQty: {productQuantity}\n";
            Console.WriteLine(packingLabelContents);
        }
    }

    public float GetShippingPrice(string domestic)
    {
        if (domestic == "yes")
        {
            _shippingPrice = 5;
        }

        else
        {
            _shippingPrice = 35;
        }

        return _shippingPrice;
    }

    public float GetOrderPrice(float shippingPrice, List<List<string>> orderContent)
    {
        float currentProductTotal = 0;

        foreach (List<string> product in orderContent)
        {
            float productPrice = float.Parse(product[2]);
            float productQuantity = float.Parse(product[3]);
            float productTotal = productPrice * productQuantity;
            currentProductTotal = currentProductTotal + productTotal;
        }

        float orderTotal = currentProductTotal + shippingPrice;
        return orderTotal;
    }
}