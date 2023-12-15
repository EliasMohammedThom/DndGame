using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Inventory
    {
        [Key] public int Id { get; set; }
        public int CharacterId { get; set; }
    }
}