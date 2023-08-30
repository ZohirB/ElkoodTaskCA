using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.CompanyInfos.Commands.Create;

public class CreateCompanyInfoCommand 
{
    public class Request : IRequest<CompanyInfo>
    {
        [MaxLength(100)] public string Name { get; set; }

        [MaxLength(100)] public string location { get; set; }

        public DateTime establishmentDate { get; set; }

        [MaxLength(100)] public string activity { get; set; }
    }
}