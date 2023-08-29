namespace ElkoodTaskCA.Contracts.Dtos.MainDtos;

public class ProductInfoDto
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)] public string Name { get; set; }

    public int ProductTypeId { get; set; }
    public string ProductType { get; set; }

}