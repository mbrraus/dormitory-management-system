namespace DormitoryManagement.Data.Models;

public class Ticket
{
    public Guid Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public bool IsClosed { get; set; }
    
    public Guid StudentId { get; set; }
    public virtual Student Student { get; set; }
    
    public Guid RoomId { get; set; }
    public virtual Room Room { get; set; }
}