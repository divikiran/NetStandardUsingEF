using System;
using NetStandard2.Entities;
using NetStandard2.Repositories.Base;

namespace NetStandard2.Repositories.PersonRepository
{
    public interface IPersonRepository : IRepository<PersonEntity>
    {
    }
}
