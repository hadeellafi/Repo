using Eman.Data;
using Eman.Models.Entities;
using Eman.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eman.Models.Services
{
    public class OwnerService : IOwner
    {
        private readonly RepoDbContext _context;

        public OwnerService(RepoDbContext context)
        {
            _context = context;
        }
        public async Task<Owner> Create(Owner owner)
        {
            
            await _context.Owners.AddAsync(owner);
            await _context.SaveChangesAsync();
            return owner;
        }

        public async Task<List<Owner>> GetOwners()
        {
            var owners = await _context.Owners.ToListAsync();
            return owners;
        }


        public async Task<Owner> GetOwner(int id)
        {
            var owner = await _context.Owners.FindAsync(id);
            return owner;
        }

    }
}
