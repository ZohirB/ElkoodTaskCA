using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.ProductInfoQuery;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}