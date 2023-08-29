using ElkoodTaskCA.Domain.Models.MainEntities;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface IBranchTypesService
{
    Task<IEnumerable<BranchType>> GetAllBranchType();
    Task<BranchType> GetBranchTypeById(int id);
    Task<BranchType> CreateBranchType(BranchType branchType);
    BranchType UpdateBranchType(BranchType branchType);
    //BranchType DeleteBranchType(BranchType branchType);
}