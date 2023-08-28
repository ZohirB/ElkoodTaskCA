using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.CompanyInfo.Commands.Create;

public class CreateCompanyInfoHandler : IRequestHandler<CreateCompanyInfoCommand, Domain.Models.CompanyInfo>
{
    private readonly ICompaniesInfoService _companiesInfoService;

    public CreateCompanyInfoHandler(ICompaniesInfoService companiesInfoService)
    {
        _companiesInfoService = companiesInfoService;
    }


    public async Task<Domain.Models.CompanyInfo> Handle(CreateCompanyInfoCommand request, CancellationToken cancellationToken)
    {
        var companyInfo = await _companiesInfoService.AddCompanyInfo(request);
        return companyInfo;
    }
}