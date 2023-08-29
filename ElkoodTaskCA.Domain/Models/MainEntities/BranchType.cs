namespace ElkoodTaskCA.Domain.Models.MainEntities;

public class BranchType
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)] public string Name { get; set; }
}