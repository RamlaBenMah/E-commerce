
using E_commerce.Server.Data;
using E_commerce.Server.Migrations;
using Microsoft.EntityFrameworkCore;
using E_commerce.Shared;
using Microsoft.Identity.Client;
namespace E_commerce.Server.services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;

        public StatsService( DataContext context)
        {
            _context = context;
        }
        public async Task<int> GetVisits()
        {
            var stat = await _context.Stats.FirstOrDefaultAsync();
            if(stat == null)
            {
                return 0;
            }
            return stat.Visits;
        }

        public async Task IncrementVisits()
        {
            var stat = await _context.Stats.FirstOrDefaultAsync();
            if (stat == null)
            {
                _context.Stats.Add(new E_commerce.Shared.Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stat.Visits++;
                stat.LastVisit = DateTime.Now;
            }
            await _context.SaveChangesAsync();
        }
    }
}
