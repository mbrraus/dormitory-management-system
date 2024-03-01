namespace DormitoryManagement.Ticket;

public class CreateTicketRequest
{
    public Guid StudentId { get; set; }
    
    public Guid RoomId { get; set; }

    public string Message { get; set; } = string.Empty;
}