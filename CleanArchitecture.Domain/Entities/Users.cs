using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities;

public class Users
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; }

    public string UserEmail { get; set; }

    public string Password { get; set; }
}
