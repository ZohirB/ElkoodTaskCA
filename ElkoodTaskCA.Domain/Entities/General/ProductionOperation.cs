﻿namespace ElkoodTaskCA.Domain.Entities.General;

public class ProductionOperation
{
    public ProductionOperation()
    {
        RemainingQuantity = Quantity;
    }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int BranchInfoId { get; set; }
    public BranchInfo BranchInfo { get; set; }

    public int ProductInfoId { get; set; }
    public ProductInfo ProductInfo { get; set; }

    public int Quantity { get; set; }
    public int RemainingQuantity { get; set; }
    public DateTime Date { get; set; }
}