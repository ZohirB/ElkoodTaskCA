using ElkoodTaskCA.Domain.Dtos;

namespace ElkoodTaskCA.Application.Repositories.ProductProducedRepository;

public interface IProductProducedService
{
    Task<List<ProductProducedDetailsDto>> GetAllProductProduced(string companyName, DateTime startDate,
        DateTime endDate);

    Task<bool> IsValidCompanyName(string companyName);
}