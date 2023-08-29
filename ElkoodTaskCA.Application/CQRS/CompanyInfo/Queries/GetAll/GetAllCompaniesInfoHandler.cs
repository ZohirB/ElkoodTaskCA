using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.CompanyInfo.Queries.GetAll;

public class GetAllCompaniesInfoHandler : IRequestHandler<GetAllCompaniesInfoQuery, IEnumerable<Domain.Models.MainEntities.CompanyInfo>>
{
    private readonly ICompaniesInfoService _companiesInfoService;

    public GetAllCompaniesInfoHandler(ICompaniesInfoService companiesInfoService)
    {
        _companiesInfoService = companiesInfoService;
    }


    public async Task<IEnumerable<Domain.Models.MainEntities.CompanyInfo>> Handle(GetAllCompaniesInfoQuery request,
        CancellationToken cancellationToken)
    {
        var companyInfo = await _companiesInfoService.GetAllCompanyInfo();
        return companyInfo;
    }
}