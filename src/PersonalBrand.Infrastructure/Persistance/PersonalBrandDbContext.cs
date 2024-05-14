using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalBrand.Application.Abstractions;
using PersonalBrand.Domain.DTOs;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Infrastructure.Persistance
{
    public class PersonalBrandDbContext : IdentityDbContext<UserModel>, IPersonalBrandDbContext
    {
        public PersonalBrandDbContext(DbContextOptions<PersonalBrandDbContext> options) : base(options)
        {

        }

        public DbSet<Login> TestLoginTable { get; set; }
    }
}
