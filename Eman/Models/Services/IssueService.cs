using Eman.Data;
using Eman.Models.Entities;
using Eman.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eman.Models.Services
{
    public class IssueService : IIssue
    {
        private readonly RepoDbContext _context;

        public IssueService(RepoDbContext context)
        {
            _context = context;
        }

        public async Task<Issue> Create(Issue issue)
        {
            _context.Issues.Add(issue);
            await _context.SaveChangesAsync();

            return issue;
        }

        public async Task<Issue> GetIssue(int id)
        {
            var issue = await _context.Issues.FindAsync(id);
            return issue;
        }

        public async Task<List<Issue>> GetIssues()
        {
            var issues = await _context.Issues.ToListAsync();
            return issues;
        }
    }
}
