using ElkoodTaskCA.Application.CQRS.ProductionOpration.Commands.Create;
using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Domain.Models;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface IProductionOperationService
{
    Task<List<ProductionDetailsDto>> GetAllProductionOperations();
    Task<ProductionOperation> CreateProductionOperation(CreateProductionOprationCommand productionOprerationDto);
    Task<bool> IsValidBranchInfo(int branchInfoId);
    Task<bool> IsValidProductInfo(int productInfoId);
    Task<bool> IsValidBranchType(int branchInfoId);
}