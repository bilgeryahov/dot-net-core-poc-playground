using dot_net_core_poc_playground.Utilities;

namespace dot_net_core_poc_playground.Models
{
    [GeneratedController("api/book")]
    public class BookModel : BaseModel
    {
        public string Author { get; set; }
    }
}
