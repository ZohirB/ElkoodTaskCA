using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface IProductProducedService
{
    Task<List<ProductProducedDetailsDto>> GetAllProductProduced(string companyName, DateTime startDate,
        DateTime endDate);

    Task<bool> IsValidCompanyName(string companyName);
}