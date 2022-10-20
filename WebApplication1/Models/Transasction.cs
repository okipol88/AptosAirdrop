namespace WebApplication1.Models
{
    public class Transasction
  {
    public string type { get; set; }
    public string function { get; set; }
    public List<object> arguments { get; set; }
    public List<object> type_arguments { get; set; }

  }
}
