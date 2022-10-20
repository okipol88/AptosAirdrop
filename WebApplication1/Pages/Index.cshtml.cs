using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Abstractions;

namespace WebApplication1.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    private readonly ITransactionProvider _transactionProvider;

    public IndexModel(ILogger<IndexModel> logger, ITransactionProvider transactionProvider)
    {
      _logger = logger;
      _transactionProvider = transactionProvider;
    }

    [BindProperty] public Models.Transasction Tx { get; set; }

    public async Task OnGet()
    {
     Tx = await _transactionProvider.GetTransaction();

    }
  }
}