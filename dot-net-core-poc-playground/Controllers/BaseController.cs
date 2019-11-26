using System.Collections.Generic;
using dot_net_core_poc_playground.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_core_poc_playground.Controllers
{
    [Route("api/[controller]")]
    public class BaseController<BaseModel> : Controller where BaseModel : Models.BaseModel
    {
        private Storage<BaseModel> _storage;

        public BaseController(Storage<BaseModel> storage)
        {
            _storage = storage;
        }

        [HttpPost]
        public void Post([FromBody]BaseModel value)
        {
            _storage.Create(value);
        }

        [HttpGet]
        public IEnumerable<BaseModel> Get()
        {
            return _storage.ReadAll();
        }

        [HttpGet("{id}")]
        public BaseModel Get(int id)
        {
            return _storage.ReadOne(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]BaseModel value)
        {
            _storage.Update(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _storage.Delete(id);
        }
    }
}
