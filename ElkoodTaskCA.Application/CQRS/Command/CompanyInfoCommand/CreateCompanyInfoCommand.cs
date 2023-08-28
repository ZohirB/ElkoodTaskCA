using ElkoodTaskCA.Domain.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Command.CompanyInfoCommand;

public class CreateCompanyInfoCommand : IRequest<CompanyInfo>
{
    [MaxLength(100)] public string Name { get; set; }

    [MaxLength(100)] public string location { get; set; }

    public DateTime establishmentDate { get; set; }

    [MaxLength(100)] public string activity { get; set; }
}