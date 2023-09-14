using Eman.Models.Entities;

namespace Eman.Models.Interfaces
{
    public interface IOwner
    {
        // CREATE
        Task<Owner> Create(Owner owner);

        // GET ALL
        Task<List<Owner>> GetOwners();

        // GET ONE BY ID
        Task<Owner> GetOwner(int id);

        //// UPDATE
        //Task<Owner> UpdateOwner(int id, Owner owner);

        //// DELETE
        //Task Delete(int id);
    }
}
