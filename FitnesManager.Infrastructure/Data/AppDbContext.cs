﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesManager.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
