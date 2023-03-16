namespace ObserverPatternExample;

/// <summary>
///     The 'Observer' interface
/// </summary>
internal interface IInvestor
{
    void Update(Stock stock);
}