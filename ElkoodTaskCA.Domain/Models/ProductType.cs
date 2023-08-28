using System.ComponentModel.DataAnnotations.Schema;

namespace ElkoodTaskCA.Domain.Models;

public class ProductType
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)] public string Name { get; set; }
}