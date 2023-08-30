using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.ProductInfos.Queries.GetAll;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}