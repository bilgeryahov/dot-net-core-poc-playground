using System.Collections.Generic;
using System.Linq;

namespace dot_net_core_poc_playground.Utilities
{
    public class Storage<BaseModel> where BaseModel : Models.BaseModel
    {
        private Dictionary<int, BaseModel> storage = new Dictionary<int, BaseModel>();
        private int idCount = 0;

        public void Create(BaseModel item)
        {
            item.Id = idCount;
            storage[idCount] = item;
            idCount++;
        }

        public IEnumerable<BaseModel> ReadAll() => storage.Values;

        public BaseModel ReadOne(int id)
        {
            return storage.FirstOrDefault(x => x.Key == id).Value;
        }

        public void Update(int id, BaseModel item)
        {
            item.Id = id;
            storage[id] = item;
        }

        public void Delete(int id)
        {
            storage.Remove(id);
        }
    }
}
