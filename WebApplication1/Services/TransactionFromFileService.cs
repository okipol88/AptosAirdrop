using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Services
{
  public class TransactionFromFileService : Abstractions.ITransactionProvider
  {
    private readonly string _filePath;

    public TransactionFromFileService(string filePath)
    {
      _filePath = filePath;
    }

    public Task<Transasction> GetTransaction()
    {
      try
      {
        var txt = File.ReadAllText(_filePath);
       var result =  JsonSerializer.Deserialize<Transasction>(txt, options: null) ?? throw new Exception("Could not get result");

        return Task.FromResult(result);
      }
      catch (Exception ex)
      {
        throw;
      }
    }
  }
}
