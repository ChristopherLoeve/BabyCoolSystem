using RestCareService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DR_RestService.Managers
{
    public class DbService
    {
        public DbService()
        {

        }
        

        public async Task<IEnumerable<BabyData>> GetAsync()
        {
            await using (var context = new BabyDataDbContext())
            {
                return await context.Set<BabyData>().AsNoTracking().ToListAsync();
            }
        }


        public async Task<bool> CreateAsync(BabyData babyData)
        {
            await using (var context = new BabyDataDbContext())
            {
                try
                {
                    context.Set<BabyData>().Add(babyData);
                    await context.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {
                    throw new ArgumentException($"Could not add BabyData");
                }
            }
        }
    }
}
