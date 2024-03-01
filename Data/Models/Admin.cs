using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement.Data.Models;


[Table(name:"AdminUsers")]
public class Admin
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}