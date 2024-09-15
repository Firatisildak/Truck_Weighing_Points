using GeotekProject.Application.Interfaces;
using GeotekProject.Domain.Entities;
using GeotekProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Persistence.Repositories
{
    public class KantarRepository : GenericRepository<Kantar>, IKantarRepository
    {
        public KantarRepository(GeotekProjectDbContext context) : base(context)
        {
        }
        public async Task<IList<Kantar>> GetAllWithKamyonAsync()
        {
            return await Table.Include(b => b.Kamyon).ToListAsync();
        }
    }
}
