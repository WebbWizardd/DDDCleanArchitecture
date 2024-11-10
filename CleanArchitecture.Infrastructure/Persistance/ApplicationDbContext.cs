using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistance;

internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):DbContext(options)
{
    internal DbSet<Users> Users { get; set; }
}
