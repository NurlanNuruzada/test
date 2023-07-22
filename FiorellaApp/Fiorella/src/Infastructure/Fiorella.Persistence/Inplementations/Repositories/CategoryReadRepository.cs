﻿using Fiorella.Aplication.Abstraction.Repostiory;
using Fiorella.Domain.Entities;
using Fiorella.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Persistence.Inplementations.Repositories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
