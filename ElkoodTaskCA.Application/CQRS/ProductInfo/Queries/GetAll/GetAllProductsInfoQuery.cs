using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductInfo.Queries.GetAll;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}