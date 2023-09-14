using Eman.Models.Entities;

namespace Eman.Models.Interfaces
{
    public interface IIssue
    {

        // CREATE
        Task<Issue> Create(Issue issue);

        // GET ALL
        Task<List<Issue>> GetIssues();

        // GET ONE BY ID
        Task<Issue> GetIssue(int id);



        //// UPDATE
        //Task<Issue> UpdateOwnerint id, Owner category);

        //// DELETE
        //Task Delete(int id);

    }

}

