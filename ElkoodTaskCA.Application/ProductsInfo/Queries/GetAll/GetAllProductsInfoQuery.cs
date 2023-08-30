using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.ProductsInfo.Queries.GetAll;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}