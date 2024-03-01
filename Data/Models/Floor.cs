using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement.Data.Models;


[Table(name:"Floors")]
public class Floor
{
    public Guid Id { get; set; }
    public required int Number { get; set; }
    public Guid BuildingId { get; set; }
    public Building Building { get; set; } = null!;
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}