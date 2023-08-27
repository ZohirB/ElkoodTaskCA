using ElkoodTaskCA.Application.CQRS.Command.CompanyInfoCommand;
using ElkoodTaskCA.Domain.Models;

namespace ElkoodTaskCA.Presistence.Repositories.CompanyInfoRepository;

public interface ICompaniesInfoService
{
    Task<IEnumerable<CompanyInfo>> GetAllCompanyInfo();
    Task<CompanyInfo> GetCompanyInfoById(int id);
    Task<CompanyInfo> AddCompanyInfo(CreateCompanyInfoCommand companyInfo);
    CompanyInfo UpdateCompanyInfo(CompanyInfo companyInfo);
    CompanyInfo DeleteCompanyInfo(CompanyInfo companyInfo);
}