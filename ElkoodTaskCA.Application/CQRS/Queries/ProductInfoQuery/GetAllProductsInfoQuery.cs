using ElkoodTaskCA.Application.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.ProductInfoQuery;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}