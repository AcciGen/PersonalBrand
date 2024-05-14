using Microsoft.EntityFrameworkCore;
using PersonalBrand.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Application.Abstractions
{
    public interface IPersonalBrandDbContext
    {
        public DbSet<Login> TestLoginTable { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
