﻿using Microsoft.EntityFrameworkCore;
using Mumbi.Application.Interfaces.Repositories;
using Mumbi.Domain.Entities;
using Mumbi.Infrastucture.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Infrastucture.Repositories
{
   
    public class InjectedPersonRepository : GenericRepository<InjectedPerson>, IInjectedPersonRepository
    {
        private readonly DbSet<InjectedPerson> _child;

        public InjectedPersonRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _child = dbContext.Set<InjectedPerson>();
        }
    }
}