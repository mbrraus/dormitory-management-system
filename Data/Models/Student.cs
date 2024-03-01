using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement.Data.Models;

[Table(name:"Students")]
public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; }
    public string PasswordHash { get; set; }
    
    public string InitialPassword { get; set; }
    
    public Guid? RoomAssignmentId { get; set; }
    public virtual RoomAssignment? RoomAssignment { get; set; }
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    
}
