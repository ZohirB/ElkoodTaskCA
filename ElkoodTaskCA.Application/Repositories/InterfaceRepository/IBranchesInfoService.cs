using ElkoodTaskCA.Application.CQRS.BranchInfo.Commands.Create;
using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Models;
using ElkoodTaskCA.Domain.Models.MainEntities;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

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