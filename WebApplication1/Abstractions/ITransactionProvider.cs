using WebApplication1.Models;

namespace WebApplication1.Abstractions
{
    public interface ITransactionProvider
    {
      Task<Transasction> GetTransaction();

    }
}
