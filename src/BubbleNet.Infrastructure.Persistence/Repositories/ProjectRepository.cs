using BubbleNet.Core.Models;
using BubbleNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    public class ProjectRepository: Repository<Project>, BubbleNet.Core.Repositories.IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public Dictionary<string,string> GetProjectList()
        {
          return  _context.Set<Project>().ToDictionary(x => x.ProjectId.ToString(), x => x.ProjectName);
        }

        public ApplicationDbContext ApplicationContext
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}
