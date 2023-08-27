using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.CompanyInfoQuery;

public class GetAllCompaniesInfoQuery : IRequest<IEnumerable<CompanyInfo>>
{
}