using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ABCRetailApp.Models
{
    [Table("Products")]
    public class Product : BaseModel
    {
        [PrimaryKey("id", false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Column("price")]
        public decimal Price { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}