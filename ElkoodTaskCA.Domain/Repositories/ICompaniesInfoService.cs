using System.Collections.Generic;
using System.Threading.Tasks;
using ElkoodTaskCA.Domain.Entities.General;

namespace ElkoodTaskCA.Domain.Repositories;

public interface ICompaniesInfoService
{
    Task<IEnumerable<CompanyInfo>> GetAllCompanyInfo();
    Task<CompanyInfo> GetCompanyInfoById(int id);
    Task<CompanyInfo> AddCompanyInfo(CompanyInfo companyInfo);
    CompanyInfo UpdateCompanyInfo(CompanyInfo companyInfo);
    //CompanyInfo DeleteCompanyInfo(CompanyInfo companyInfo);
}