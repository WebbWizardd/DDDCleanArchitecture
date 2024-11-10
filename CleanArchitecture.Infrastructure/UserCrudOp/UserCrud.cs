using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.UserCrudOp;

internal class UserCrud(ApplicationDbContext dbContext) : IUserCrud
{
    public List<Users> GetAllUsers()
    {
        var users = dbContext.Users.ToList();
        return users;
    }

    public async Task AddUser(Users user)
    {
        await dbContext.Users.AddAsync(user);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteUser(int id)
    {
        var data = dbContext.Users.FirstOrDefault(x => x.Id == id);

        if (data != null)
        {
            dbContext.Users.Remove(data);
            await dbContext.SaveChangesAsync();
        }
    }
}
