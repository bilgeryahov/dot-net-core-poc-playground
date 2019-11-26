using dot_net_core_poc_playground.Models;
using dot_net_core_poc_playground.Utilities;

namespace dot_net_core_poc_playground.Controllers
{
    public class AlbumController : BaseController<AlbumModel>
    {
        public AlbumController(Storage<AlbumModel> storage) : base(storage)
        {
        }
    }
}
