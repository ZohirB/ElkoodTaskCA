using ElkoodTaskCA.API.CQRS.Queries.CompanyInfoQuery;
using ElkoodTaskCA.API.Repositories.CompanyInfoRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.CompanyInfoHandler;

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