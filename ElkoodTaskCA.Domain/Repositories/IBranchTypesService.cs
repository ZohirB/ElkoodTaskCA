using ElkoodTaskCA.Domain.Entities.General;

namespace ElkoodTaskCA.Domain.Repositories;

public interface IBranchTypesService
{
    Task<IEnumerable<BranchType>> GetAllBranchType();
    Task<BranchType> GetBranchTypeById(int id);
    Task<BranchType> CreateBranchType(BranchType branchType);
    BranchType UpdateBranchType(BranchType branchType);
    //BranchType DeleteBranchType(BranchType branchType);
}