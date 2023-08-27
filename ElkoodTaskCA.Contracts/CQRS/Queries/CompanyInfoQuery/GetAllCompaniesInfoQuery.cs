using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.CompanyInfoQuery;

public class GetAllCompaniesInfoQuery : IRequest<IEnumerable<CompanyInfo>>
{
}