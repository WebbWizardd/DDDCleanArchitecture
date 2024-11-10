using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.UserCrudOp
{
    public interface IUserCrud
    {
        Task AddUser(Users user);
        Task DeleteUser(int id);
        List<Users> GetAllUsers();
    }
}