using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Persistence.Repositories;

public class CompaniesInfoService : ICompaniesInfoService
{
    private readonly ElkoodTaskCADbContext _context;

    public CompaniesInfoService(ElkoodTaskCADbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CompanyInfo>> GetAllCompanyInfo()
    {
        return await _context.CompanyInfo.ToListAsync();
    }

    public async Task<CompanyInfo> AddCompanyInfo(CompanyInfo companyInfo)
    {
        await _context.AddAsync(companyInfo);
        _context.SaveChanges();
        return companyInfo;
    }

    /*
    public CompanyInfo DeleteCompanyInfo(CompanyInfo companyInfo)
    {
        _context.Remove(companyInfo);
        _context.SaveChanges();
        return companyInfo;
    }
    */
    public async Task<CompanyInfo> GetCompanyInfoById(int id)
    {
        return await _context.CompanyInfo.SingleOrDefaultAsync(ci => ci.Id == id);
    }

    public CompanyInfo UpdateCompanyInfo(CompanyInfo companyInfo)
    {
        _context.Update(companyInfo);
        _context.SaveChanges();
        return companyInfo;
    }
}