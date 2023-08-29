using ElkoodTaskCA.Application.CQRS.ProductionOpration.Commands.Create;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Models.MainEntities;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface IProductionOperationService
{
    Task<List<ProductionDetailsDto>> GetAllProductionOperations();
    Task<ProductionOperation> CreateProductionOperation(CreateProductionOprationCommand productionOprerationDto);
    Task<bool> IsValidBranchInfo(int branchInfoId);
    Task<bool> IsValidProductInfo(int productInfoId);
    Task<bool> IsValidBranchType(int branchInfoId);
}