namespace ObserverPatternExample;

/// <summary>
///     The 'ConcreteSubject' class
/// </summary>
internal class CloudCoverStock : Stock
{
    // Constructor
    public CloudCoverStock(string symbol, double price)
        : base(symbol, price)
    {
    }
}