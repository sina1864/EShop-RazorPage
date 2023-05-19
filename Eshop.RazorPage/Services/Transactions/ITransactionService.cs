using Eshop.RazorPage.Models;

namespace Eshop.RazorPage.Services.Transactions;

public interface ITransactionService
{
    Task<ApiResult<string>> CreateTransaction(CreateTransactionCommand command);
}

public class CreateTransactionCommand
{
    public long OrderId { get; set; }
    public string SuccessCallBackUrl { get; set; }
    public string ErrorCallBackUrl { get; set; }
}