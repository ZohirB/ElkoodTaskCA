﻿using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Persistence.Repositories;

public class BranchesInfoService : IBranchesInfoService
{
    private readonly ElkoodTaskCADbContext _context;

    public BranchesInfoService(ElkoodTaskCADbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BranchDetailsDto>> GetAllBranchInfo()
    {
        var brancheInfo = await _context.BranchInfo
            .Include(bi => bi.CompanyInfo)
            .Select(pi => new BranchDetailsDto
            {
                Id = pi.Id,
                Name = pi.Name,
                BranchTypeName = pi.BranchType.Name,
                CompanyInfoName = pi.CompanyInfo.Name,
                location = pi.Location
            })
            .ToListAsync();
        return brancheInfo;
    }

    public async Task<BranchInfo> CreateBranchInfo(BranchInfo branchInfo)
    {
        _context.Add(branchInfo);
        await _context.SaveChangesAsync();
        return branchInfo;
    }

    public async Task<BranchInfo> UpdateBranchInfo(int id, BranchInfo branchInfoRequest)
    {
        var branchInfo = await IsValidBranchInfo(id);
        branchInfo.Name = branchInfoRequest.Name;
        branchInfo.BranchTypeId = branchInfoRequest.BranchTypeId;
        branchInfo.CompanyInfoId = branchInfoRequest.CompanyInfoId;
        branchInfo.Location = branchInfoRequest.Location;
        await _context.SaveChangesAsync();
        return branchInfo;
    }

    public async Task<BranchInfo> DeleteBranchInfo(BranchInfo branchInfo)
    {
        _context.BranchInfo.Remove(branchInfo);
        await _context.SaveChangesAsync();
        return branchInfo;
    }

    public async Task<bool> IsValidBranchType(int branchTypeId)
    {
        return await _context.BranchTypes.AnyAsync(bi => bi.Id == branchTypeId);
    }

    public async Task<bool> IsValidCompanyInfo(int companyInfoId)
    {
        return await _context.CompanyInfo.AnyAsync(bi => bi.Id == companyInfoId);
    }

    public async Task<BranchInfo> IsValidBranchInfo(int branchInfoId)
    {
        var branchInfo = await _context.BranchInfo.SingleOrDefaultAsync(bi => bi.Id == branchInfoId);
        return branchInfo;
    }
}