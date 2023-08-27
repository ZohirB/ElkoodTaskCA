using ElkoodTaskCA.API.CQRS.Command.ProductionOprationCommand;

namespace ElkoodTaskCA.API.Repositories.ProductionOperationRepository;

public interface IProductionOperationService
{
    Task<List<ProductionDetailsDto>> GetAllProductionOperations();
    Task<ProductionOperation> CreateProductionOperation(CreateProductionOprationCommand productionOprerationDto);
    Task<bool> IsValidBranchInfo(int branchInfoId);
    Task<bool> IsValidProductInfo(int productInfoId);
    Task<bool> IsValidBranchType(int branchInfoId);
}