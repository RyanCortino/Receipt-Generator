using Microsoft.Extensions.Logging;
using ReceiptGenerator.Domain.Common.Interfaces;
using ReceiptGenerator.Domain.ValueObjects;
using System.Text;

namespace ReceiptGenerator.ConsoleUi.Services;

public class Demonstration : IEntryService
{
    //public readonly ICartService _cart;
    private readonly ILogger _logger;

    public Demonstration(ILogger<Demonstration> logger)//, ICartService cart)
    {
        _logger = logger;
        //_cart = cart;
    }

    public void Run(string[] args)
        => MainAsync(args).GetAwaiter().GetResult();

    private async Task MainAsync(string[] args)
    {
        //_cart.AddLine(Item.Book, 1);
        //_cart.AddLine(Item.BarOfSoap, 1);
        //_cart.AddLine(Item.BoxOfCereal, 1);
        //LogCartDetails(cartId: 1);

        //_cart.ClearCart();
        //_cart.AddLine(Item.Magazine, 1);
        //_cart.AddLine(Item.VideoGame, 1);
        //_cart.AddLine(Item.BoxOfExpensiveCereal, 1);
        //_cart.AddLine(Item.BoxOfBandAids, 1);
        //_cart.ApplyFirstTime15Discount();
        //LogCartDetails(cartId: 2);

        //_cart.ClearCart();
        //_cart.AddLine(Item.Magazine, 2);
        //_cart.AddLine(Item.VideoGame, 1);
        //_cart.AddLine(Item.BoxOfExpensiveCereal, 2);
        //_cart.AddLine(Item.BoxOfBandAids, 1);
        //_cart.ApplyFirstTime15Discount();
        //LogCartDetails(cartId: 3);

        // block this task until the program is closed
        _logger.LogInformation($"Ctrl + C to break.");
        await Task.Delay(Timeout.Infinite);
    }

    //private void LogCartDetails(int cartId)
    //{
    //    _logger.LogInformation($"Shopping Cart {cartId}: ");
    //    _logger.LogInformation($"{_cart}");
    //}
}