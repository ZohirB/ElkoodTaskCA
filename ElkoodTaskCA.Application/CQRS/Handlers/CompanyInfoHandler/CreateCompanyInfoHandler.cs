using ElkoodTaskCA.Application.CQRS.Command.CompanyInfoCommand;
using ElkoodTaskCA.Application.Repositories.CompanyInfoRepository;
using ElkoodTaskCA.Domain.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.CompanyInfoHandler;

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