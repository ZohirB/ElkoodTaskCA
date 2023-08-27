using ElkoodTaskCA.Application.CQRS.Command.BranchInfoCommand;
using ElkoodTaskCA.Domain.Dtos;
using ElkoodTaskCA.Domain.Models;

namespace ElkoodTaskCA.Application.Repositories.BranchInfoRepository;

public interface IBranchesInfoService
{
    Task<IEnumerable<BranchDetailsDto>> GetAllBranchInfo();
    Task<BranchInfo> CreateBranchInfo(CreateBranchInfoCommand branchInfoDto);
    Task<BranchInfo> UpdateBranchInfo(int id, BranchInfo branchInfo);
    Task<BranchInfo> DeleteBranchInfo(BranchInfo branchInfo);
    Task<bool> IsValidBranchType(int branchTypeId);
    Task<bool> IsValidCompanyInfo(int companyInfoId);

    Task<BranchInfo> IsValidBranchInfo(int companyInfoId);
}