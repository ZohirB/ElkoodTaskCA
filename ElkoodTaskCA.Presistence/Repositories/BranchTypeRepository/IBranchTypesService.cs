using ElkoodTaskCA.Domain.Models;

namespace ElkoodTaskCA.Presistence.Repositories.BranchTypeRepository;

public interface IBranchTypesService
{
    Task<IEnumerable<BranchType>> GetAllBranchType();
    Task<BranchType> GetBranchTypeById(int id);
    Task<BranchType> CreateBranchType(BranchType branchType);
    BranchType UpdateBranchType(BranchType branchType);
    BranchType DeleteBranchType(BranchType branchType);
}