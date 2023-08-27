using ElkoodTaskCA.Application.CQRS.Queries.CompanyInfoQuery;
using ElkoodTaskCA.Domain.Models;
using ElkoodTaskCA.Domain.Repositories.CompanyInfoRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.CompanyInfoHandler;

public class GetAllCompaniesInfoHandler : IRequestHandler<GetAllCompaniesInfoQuery, IEnumerable<CompanyInfo>>
{
    private readonly ICompaniesInfoService _companiesInfoService;

    public GetAllCompaniesInfoHandler(ICompaniesInfoService companiesInfoService)
    {
        _companiesInfoService = companiesInfoService;
    }


    public async Task<IEnumerable<CompanyInfo>> Handle(GetAllCompaniesInfoQuery request,
        CancellationToken cancellationToken)
    {
        var companyInfo = await _companiesInfoService.GetAllCompanyInfo();
        return companyInfo;
    }
}