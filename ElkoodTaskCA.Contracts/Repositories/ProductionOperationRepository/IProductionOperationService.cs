using ElkoodTaskCA.Contracts.CQRS.Command.ProductionOprationCommand;
using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Models;

namespace ElkoodTaskCA.Contracts.Repositories.ProductionOperationRepository;

public interface IProductionOperationService
{
    Task<List<ProductionDetailsDto>> GetAllProductionOperations();
    Task<ProductionOperation> CreateProductionOperation(CreateProductionOprationCommand productionOprerationDto);
    Task<bool> IsValidBranchInfo(int branchInfoId);
    Task<bool> IsValidProductInfo(int productInfoId);
    Task<bool> IsValidBranchType(int branchInfoId);
}