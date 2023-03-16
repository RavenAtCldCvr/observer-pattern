using System;
using System.Collections.Generic;

namespace ObserverPatternExample;

/// <summary>
///     The 'Subject' abstract class
/// </summary>
internal abstract class Stock
{
    private readonly List<IInvestor> _investors = new();
    private double _price;

    // Constructor
    protected Stock(string symbol, double price)
    {
        Symbol = symbol;
        _price = price;
    }

    // Gets or sets the price
    public double Price
    {
        get => _price;
        set
        {
            if (_price == value) return;
            _price = value;
            Notify();
        }
    }

    // Gets the symbol
    public string Symbol { get; }

    public void Attach(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void Detach(IInvestor investor)
    {
        _investors.Remove(investor);
    }

    private void Notify()
    {
        foreach (var investor in _investors) investor.Update(this);

        Console.WriteLine("");
    }
}