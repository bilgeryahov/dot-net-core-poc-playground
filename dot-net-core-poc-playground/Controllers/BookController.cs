using dot_net_core_poc_playground.Models;
using dot_net_core_poc_playground.Utilities;

namespace dot_net_core_poc_playground.Controllers
{
    public class BookController : BaseController<BookModel>
    {
        public BookController(Storage<BookModel> storage) : base(storage)
        {
        }
    }
}
