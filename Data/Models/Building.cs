using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement.Data.Models;


[Table(name:"Buildings")]
public class Building
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Floor> Floors { get; set; } = new List<Floor>();
}