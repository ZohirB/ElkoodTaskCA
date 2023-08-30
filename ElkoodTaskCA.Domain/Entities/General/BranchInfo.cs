﻿namespace ElkoodTaskCA.Domain.Entities.General;

public class BranchInfo
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)] public string Name { get; set; }

    public int BranchTypeId { get; set; }
    public BranchType BranchType { get; set; }
    public int CompanyInfoId { get; set; }
    public CompanyInfo CompanyInfo { get; set; }

    [MaxLength(100)] public string Location { get; set; }

    public ICollection<ProductionOperation> ProductionOperations { get; set; }
    public ICollection<DistributionOperation> DistributionOperations { get; set; }
}