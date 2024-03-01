using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement.Data.Models;


[Table(name:"InventoryItems")]
public class InventoryItem
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
}