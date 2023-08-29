using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductInfo.Queries.GetAll;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}