﻿using GeotekProject.Application.Interfaces;
using GeotekProject.Domain.Entities;
using GeotekProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Persistence.Repositories
{
    public class KamyonRepository(GeotekProjectDbContext context) : GenericRepository<Kamyon>(context), IKamyonRepository
    {
    }
}
