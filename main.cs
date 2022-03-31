using MyLib;

StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
stockExchangeMonitor.PriceChangeHandler = ShowPrice;

stockExchangeMonitor.Start();

static void ShowPrice(int price)
{
    Console.WriteLine($"New price is {price}");
}
