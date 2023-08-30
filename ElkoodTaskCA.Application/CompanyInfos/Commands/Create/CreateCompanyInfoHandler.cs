using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using MediatR;

namespace ElkoodTaskCA.Application.CompanyInfos.Commands.Create;

public class CreateCompanyInfoHandler : IRequestHandler<CreateCompanyInfoCommand.Request, CompanyInfo>
{
    private readonly ICompaniesInfoService _companiesInfoService;

    public CreateCompanyInfoHandler(ICompaniesInfoService companiesInfoService)
    {
        _companiesInfoService = companiesInfoService;
    }


    public async Task<CompanyInfo> Handle(CreateCompanyInfoCommand.Request request, CancellationToken cancellationToken)
    {
        var companyInfo = new CompanyInfo
        {
            Name = request.Name,
            Activity = request.activity,
            EstablishmentDate = request.establishmentDate,
            Location = request.location
        }; 
        return await _companiesInfoService.AddCompanyInfo(companyInfo);
    }
}