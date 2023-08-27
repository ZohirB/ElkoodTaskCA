using ElkoodTaskCA.Application.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.CompanyInfoQuery;

public class GetAllCompaniesInfoQuery : IRequest<IEnumerable<CompanyInfo>>
{
}