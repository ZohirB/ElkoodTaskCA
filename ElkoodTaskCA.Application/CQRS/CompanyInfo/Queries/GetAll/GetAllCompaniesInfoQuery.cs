using MediatR;

namespace ElkoodTaskCA.Application.CQRS.CompanyInfo.Queries.GetAll;

public class GetAllCompaniesInfoQuery : IRequest<IEnumerable<Domain.Models.CompanyInfo>>
{
}