using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductionOpration.Queries.GetAll;

public class
    GetAllProductionOprationsHandler : IRequestHandler<GetAllProductionOprationQuery, List<ProductionDetailsDto>>
{
    private readonly IProductionOperationService _productionOperationService;

    public GetAllProductionOprationsHandler(IProductionOperationService productionOperationService)
    {
        _productionOperationService = productionOperationService;
    }

    public async Task<List<ProductionDetailsDto>> Handle(GetAllProductionOprationQuery request,
        CancellationToken cancellationToken)
    {
        var productionOperations = await _productionOperationService.GetAllProductionOperations();
        return productionOperations;
    }
}