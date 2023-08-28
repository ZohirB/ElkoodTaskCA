using ElkoodTaskCA.Application.CQRS.CompanyInfo.Commands.Create;
using ElkoodTaskCA.Domain.Models;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface ICompaniesInfoService
{
    Task<IEnumerable<CompanyInfo>> GetAllCompanyInfo();
    Task<CompanyInfo> GetCompanyInfoById(int id);
    Task<CompanyInfo> AddCompanyInfo(CreateCompanyInfoCommand companyInfo);
    CompanyInfo UpdateCompanyInfo(CompanyInfo companyInfo);
    CompanyInfo DeleteCompanyInfo(CompanyInfo companyInfo);
}