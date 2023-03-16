using System;

namespace ObserverPatternExample;

/// <summary>
///     Observer Design Pattern Example
/// </summary>
internal static class MainApp
{
    /// <summary>
    ///     Entry point into console application.
    /// </summary>
    private static void Main()
    {
        // Create IBM stock and attach investors
        var cloudCover = new CloudCoverStock("CloudCover", 80.00);
        cloudCover.Attach(new Investor("Temasek"));
        cloudCover.Attach(new Investor("ST Telemedia"));

        // Fluctuating prices will notify investors
        cloudCover.Price = 80.20;
        cloudCover.Price = 100.00;
        cloudCover.Price = 111.50;
        cloudCover.Price = 130.75;

        // Wait for user
        Console.ReadKey();
    }
}