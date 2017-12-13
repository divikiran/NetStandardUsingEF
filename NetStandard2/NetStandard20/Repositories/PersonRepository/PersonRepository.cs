using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetStandard2.Entities;
using NetStandard2.Repositories.Base;

namespace NetStandard2.Repositories.PersonRepository
{
    public class PersonRepository : Repository<PersonEntity>, IPersonRepository
    {
        public override async Task<IEnumerable<PersonEntity>> GetAll()
        {
            return await Context.PersonEntity.ToListAsync();
        }
    }
}
