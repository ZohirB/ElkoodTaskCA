using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.ProductsInfo.Commands.Create;

public class CreateProductInfoCommand 
{
    public class Request : IRequest<OperationResponse<ProductInfo>>
    {
        [MaxLength(100)] public string Name { get; set; }
        public int ProductTypeId { get; set; }
    }
}