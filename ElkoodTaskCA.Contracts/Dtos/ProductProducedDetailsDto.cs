namespace ElkoodTaskCA.Contracts.Dtos;

public class ProductProducedDetailsDto
{
    [MaxLength(100)] public string ProductName { get; set; }

    public int TotalQuantityProduced { get; set; }
}