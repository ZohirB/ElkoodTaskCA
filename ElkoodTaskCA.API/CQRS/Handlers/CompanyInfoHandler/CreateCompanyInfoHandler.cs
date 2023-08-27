using ElkoodTaskCA.API.CQRS.Command.CompanyInfoCommand;
using ElkoodTaskCA.API.Repositories.CompanyInfoRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.CompanyInfoHandler;

public class CreateCompanyInfoHandler : IRequestHandler<CreateCompanyInfoCommand, CompanyInfo>
{
    private readonly ICompaniesInfoService _companiesInfoService;

    public CreateCompanyInfoHandler(ICompaniesInfoService companiesInfoService)
    {
        _companiesInfoService = companiesInfoService;
    }


    public async Task<CompanyInfo> Handle(CreateCompanyInfoCommand request, CancellationToken cancellationToken)
    {
        var companyInfo = await _companiesInfoService.AddCompanyInfo(request);
        return companyInfo;
    }
}