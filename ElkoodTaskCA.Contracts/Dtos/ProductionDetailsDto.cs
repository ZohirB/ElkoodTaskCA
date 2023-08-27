﻿namespace ElkoodTaskCA.Domain.Dtos;

public class ProductionDetailsDto
{
    public int Id { get; set; }
    public string BranchInfoName { get; set; }
    public string ProductInfoName { get; set; }
    public int quantity { get; set; }
    public int RemainingQuantity { get; set; }
    public DateTime date { get; set; }
}