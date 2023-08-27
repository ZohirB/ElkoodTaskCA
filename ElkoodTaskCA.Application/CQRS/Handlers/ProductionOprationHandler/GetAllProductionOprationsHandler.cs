using ElkoodTaskCA.Application.CQRS.Queries.ProductionOprationQuery;
using ElkoodTaskCA.Application.Dtos;
using ElkoodTaskCA.Application.Repositories.ProductionOperationRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.ProductionOprationHandler;

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