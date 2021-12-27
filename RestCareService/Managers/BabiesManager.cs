using DR_RestService.Managers;
using RestCareService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCareService.Managers
{
    public class BabiesManager
    {
        private static readonly DbService _db = new DbService();
        public BabiesManager()
        {
        }

        public async Task<IEnumerable<BabyData>> GetAllAsync()
        {
            return await _db.GetAsync();
        }

        public async Task<bool> InsertDataAsync(BabyData newData)
        {
            await _db.CreateAsync(newData);
            return true;
        }
    }
}
