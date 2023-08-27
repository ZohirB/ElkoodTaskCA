﻿using ElkoodTaskCA.API.CQRS.Command.BranchInfoCommand;

namespace ElkoodTaskCA.API.Repositories.BranchInfoRepository;

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